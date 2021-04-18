import mysql.connector
from flask import Flask
from flask import json
from flask import request
import db_mysql

app = Flask(__name__)


def requestDd(request, value=None):
    config = {
        'user': 'root',
        'password': 'weshalors',
        'host': 'bottleflip-db',
        'port': 3306,  # normalement 3306
        'database': 'bottleflip',
        'raise_on_warnings': True
    }
    cnx = mysql.connector.connect(**config)
    cursor = cnx.cursor(dictionary=True)
    cursor.execute(request)
    if request.split(" ")[0] == "INSERT" or request.split(" ")[0] == "UPDATE":
        cnx.commit()
    results = cursor.fetchall()
    cnx.close()
    return results


@app.route("/", methods=['GET'])
def home():
    return "wesh alors"


@app.route("/database", methods=['GET'])
def database():
    db_mysql.setup()
    return app.response_class(
        status=200,
        mimetype='application/json'
    )


@app.route("/joke", methods=['GET'])
def getJoke():
    # vérification si step accepted > 0
    joke = requestDd("SELECT * FROM `jokes` WHERE step = 'JOKE_ACCEPTED' ORDER BY RAND() LIMIT 1")[0]
    joke = {
        "id": str(joke['id']),
        "joke": str(joke['joke']),
        "author": str(joke['author']),
        "step": str(joke['step'])
    }
    return app.response_class(
        response=json.dumps(joke),
        status=200,
        mimetype='application/json'
    )


@app.route("/joke/all", methods=['GET'])
def getJokes():
    response = []
    for joke in requestDd("SELECT * FROM `jokes`"):
        joke = {
            "id": str(joke['id']),
            "joke": str(joke['joke']),
            "author": str(joke['author']),
            "step": str(joke['step'])
        }
        response.append(joke)
    return app.response_class(
        response=json.dumps(response),
        status=200,
        mimetype='application/json'
    )


@app.route("/joke/all/<string:stepJoke>", methods=['GET'])
def getJokesStep(stepJoke: str):
    if stepJoke.lower() == "accepted":
        stepJoke: str = "JOKE_ACCEPTED"
    elif stepJoke.lower() == "refused":
        stepJoke: str = "JOKE_REFUSED"
    elif stepJoke.lower() == "validation":
        stepJoke: str = "VALIDATION_REQUIRED"
    else:
        return ""

    response = []

    for joke in requestDd("SELECT * FROM `jokes` WHERE step = '"+stepJoke+"'"):
        joke = {
            "id": str(joke['id']),
            "joke": str(joke['joke']),
            "author": str(joke['author']),
            "step": str(joke['step'])
        }
        response.append(joke)
    return app.response_class(
        response=json.dumps(response),
        status=200,
        mimetype='application/json'
    )


@app.route("/joke", methods=['POST'])
def addJoke():
    joke = request.json['joke']
    author = request.json['author']

    # ajouter des vérifications (si joke ou author est vide...)
    requestDd('INSERT INTO `jokes` (`joke`, `author`) VALUES ("' + joke + '", "' + author + '")')

    return app.response_class(
        response=json.dumps(
            {
                "joke": request.json['joke'],
                "author": request.json['author'],
            }
        ),
        status=200,
        mimetype='application/json'
    )


@app.route("/joke/<int:idJoke>/<string:stepJoke>", methods=['PUT'])
def stepJoke(idJoke: int, stepJoke: str):
    if stepJoke.lower() == "accepted":
        stepJoke = "JOKE_ACCEPTED"
    elif stepJoke.lower() == "refused":
        stepJoke = "JOKE_REFUSED"
    elif stepJoke.lower() == "validation":
        stepJoke = "VALIDATION_REQUIRED"
    else:
        return ""
    requestDd("UPDATE `jokes` SET `step` = '"+str(stepJoke)+"' WHERE `jokes`.`id` = "+str(idJoke))
    return app.response_class(
        response=json.dumps(
            {
                "id": str(idJoke),
                "step": stepJoke,
            }
        ),
        status=200,
        mimetype='application/json'
    )


if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
    database()


# verification required
# joke rejected
# joke accepted