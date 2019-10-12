import mysql.connector

# def request(query):
#     # connection
#     # cursor
#     # excecute
#     # return (fetchall/fetchmany/fetchone)

def request(query, fetch):
    conn = mysql.connector.connect(host="localhost", user="aymnms", password="weshalors", database="fouras")
    cursor = conn.cursor()
    cursor.execute(query)
    if fetch == 1: # fetchall
        result = cursor.fetchall()
    # elif fetch == 2: # fetchmany
    #     result je sais pas quoi
    elif fetch == 3: #fetchone
        result = cursor.fetchone()
    else:
        return None
    conn.close()
    return result

def request_insert(query):
    conn = mysql.connector.connect(host="localhost", user="aymnms", password="weshalors", database="fouras")
    cursor = conn.cursor()
    cursor.execute(query)
    conn.commit()