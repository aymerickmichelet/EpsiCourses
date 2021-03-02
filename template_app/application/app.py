from pymongo import MongoClient
from pymongo.collection import Collection
from pymongo.database import Database

from flask import Flask
from flask import json

app = Flask(__name__)

client: MongoClient = MongoClient("docker-mongodb", 27017)


@app.route("/")
def home():
    return "Wesh alors in my mongo app!"


@app.route("/info")
def info():
    return client.server_info()


@app.route("/create/db/<string:db_name>")
def create_db(db_name: str):
    mongo_database: Database = client[db_name]
    return app.response_class(
        response=json.dumps({"database created": mongo_database.name}),
        status=200,
        mimetype='application/json'
    )


@app.route("/question/0")
def question_0():
    mongo_database: Database = client["movielens"]
    mongo_collection: Collection = mongo_database["movies"]

    result_count = mongo_collection.find().count()

    return app.response_class(
        response=json.dumps({"movie count": result_count}),
        status=200,
        mimetype='application/json'
    )

@app.route("/question/1")
def question_1():
    mongo_database: Database = client["movielens"]
    mongo_collection: Collection = mongo_database["users"]

    result_count = mongo_collection.find().count()

    return app.response_class(
        response=json.dumps({"user count": result_count}),
        status=200,
        mimetype='application/json'
    )

@app.route("/question/2")
def question_2():
    mongo_database: Database = client["movielens"]
    mongo_collection: Collection = mongo_database["movies"]

    result_count = mongo_collection.find().count()

    return app.response_class(
        response=json.dumps({"movie count": result_count}),
        status=200,
        mimetype='application/json'
    )

@app.route("/question/3")
def question_3():
    mongo_database: Database = client["movielens"]
    mongo_collection: Collection = mongo_database["users"]

    result = mongo_collection.find_one({"name": "Clifford Johnathan"}, {"_id": 0, "name": 1, "occupation": 1})

    return app.response_class(
        response=json.dumps({"user": result}),
        status=200,
        mimetype='application/json'
    )


if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
