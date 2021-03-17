import mysql.connector
from flask import Flask
from flask import json
from flask import request

app = Flask(__name__)


def requestDd(request, value=None):
    config = {
        'user': 'root',
        'password': 'root',
        'host': '127.0.0.1',
        'port': 8889,  # normalement 3306
        'database': 'bottleflip',
        'raise_on_warnings': True
    }
    cnx = mysql.connector.connect(**config)
    cursor = cnx.cursor(dictionary=True)
    cursor.execute(request)
    if request.split(" ")[0] == "INSERT":
        cnx.commit()
    results = cursor.fetchall()
    cnx.close()
    return results

@app.route("/", methods=['GET'])
def home():
    return "wesh alors"


@app.route("/get_joke", methods=['GET'])
def getJoke():
    joke = requestDd("SELECT * FROM `jokes` ORDER BY RAND() LIMIT 1")[0]
    print(joke)
    joke = {
        "id": str(joke['id']),
        "joke": str(joke['joke']),
        "author": str(joke['author'])
    }
    return app.response_class(
        response=json.dumps(joke),
        status=200,
        mimetype='application/json'
    )


@app.route("/get_jokes", methods=['GET'])
def getJokes():
    response = []
    for joke in requestDd("SELECT * FROM `jokes`"):
        joke = {
            "id": str(joke['id']),
            "joke": str(joke['joke']),
            "author": str(joke['author'])
        }
        response.append(joke)
    return app.response_class(
        response=json.dumps(response),
        status=200,
        mimetype='application/json'
    )


@app.route("/add_joke", methods=['POST'])
def addJoke():
    joke = request.json['joke']
    author = request.json['author']
    requestDd("INSERT INTO `jokes` (`joke`, `author`) VALUES ('"+joke+"', '"+author+"')")
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


if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
