from pymongo import MongoClient
from pymongo.collection import Collection
from pymongo.database import Database
from pymongo.results import InsertOneResult, InsertManyResult

client: MongoClient = MongoClient("docker-mongodb", 27017)

# Create database
mongo_database: Database = client["mydatabase"]
print(client.list_database_names())

# Create collection
mongo_collection: Collection = mongo_database["customers"]
print(mongo_database.list_collection_names())

# Insert one data
data = {"name": "John", "address": "Highway 37"}
insertion: InsertOneResult = mongo_collection.insert_one(data)
print(insertion.inserted_id)

# Insert multiple documents
mylist = [
    {"name": "Amy", "address": "Apple st 652"},
    {"name": "Hannah", "address": "Mountain 21"},
    {"name": "Michael", "address": "Valley 345"},
    {"name": "Sandy", "address": "Ocean blvd 2"},
    {"name": "Betty", "address": "Green Grass 1"},
    {"name": "Richard", "address": "Sky st 331"},
    {"name": "Susan", "address": "One way 98"},
    {"name": "Vicky", "address": "Yellow Garden 2"},
    {"name": "Ben", "address": "Park Lane 38"},
    {"name": "William", "address": "Central st 954"},
    {"name": "Chuck", "address": "Main Road 989"},
    {"name": "Viola", "address": "Sideway 1633"}
]

insertions: InsertManyResult = mongo_collection.insert_many(mylist)
print(insertions.inserted_ids)

# Insert many document specifying ids
mylist = [
    {"_id": 1, "name": "John", "address": "Highway 37"},
    {"_id": 2, "name": "Peter", "address": "Lowstreet 27"},
    {"_id": 3, "name": "Amy", "address": "Apple st 652"},
    {"_id": 4, "name": "Hannah", "address": "Mountain 21"},
    {"_id": 5, "name": "Michael", "address": "Valley 345"},
    {"_id": 6, "name": "Sandy", "address": "Ocean blvd 2"},
    {"_id": 7, "name": "Betty", "address": "Green Grass 1"},
    {"_id": 8, "name": "Richard", "address": "Sky st 331"},
    {"_id": 9, "name": "Susan", "address": "One way 98"},
    {"_id": 10, "name": "Vicky", "address": "Yellow Garden 2"},
    {"_id": 11, "name": "Ben", "address": "Park Lane 38"},
    {"_id": 12, "name": "William", "address": "Central st 954"},
    {"_id": 13, "name": "Chuck", "address": "Main Road 989"},
    {"_id": 14, "name": "Viola", "address": "Sideway 1633"}
]

new_insertions: InsertManyResult = mongo_collection.insert_many(mylist)
print(new_insertions.inserted_ids)

# Find the first document
first_document = mongo_collection.find_one()
print(type(first_document))
print(first_document)

# Find many document
for document in mongo_collection.find():
    print(document)

# Find only some fields (0: no, 1: yes) => cannot specify 0 and 1 except on ID
for document in mongo_collection.find({}, {"_id": 0, "name": 1, "address": 1}):
    print(document)

# Query on field
myquery = {"address": "Park Lane 38"}

documents = mongo_collection.find(myquery)
for document in documents:
    print(document)

# Complexe query
myquery = {"address": {"$gt": "S"}}

documents = mongo_collection.find(myquery)

for document in documents:
    print(document)

# Delete
myquery = {"address": "Mountain 21"}
mongo_collection.delete_one(myquery)

# Delete many
myquery = {"address": {"$regex": "^S"}}
documents = mongo_collection.delete_many(myquery)
print(documents.deleted_count, " documents deleted.")

# Query with limit
myresult = mongo_collection.find().limit(5)

# Update one document
myquery = {"address": "Valley 345"}
newvalues = {"$set": {"address": "Canyon 123"}}

mongo_collection.update_one(myquery, newvalues)

for document in mongo_collection.find():
    print(document)

# Update many document
myquery = {"address": {"$regex": "^S"}}
newvalues = {"$set": {"name": "Minnie"}}

x = mongo_collection.update_many(myquery, newvalues)

print(x.modified_count, "documents updated.")