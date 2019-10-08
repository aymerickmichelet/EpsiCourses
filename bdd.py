import mysql.connector

# def request(query):
#     # connection
#     # cursor
#     # excecute
#     # return (fetchall/fetchmany/fetchone)

def request(query, fetch):
    print("query: ", query)
    conn = mysql.connector.connect(host="localhost", user="aymnms", password="weshalors", database="fouras")
    cursor = conn.cursor()
    cursor.execute(query)
    if fetch == 1: # fetchall
        print("fetchall")
        result = cursor.fetchall()
    # elif fetch == 2: # fetchmany
    #     result je sais pas quoi
    elif fetch == 3: #fetchone
        print("fetchone")
        result = cursor.fetchone()
    else:
        print("autre")
        return None
    print("result query:", result)
    conn.close()
    return result

def request_insert(query):
    conn = mysql.connector.connect(host="localhost", user="aymnms", password="weshalors", database="fouras")
    cursor = conn.cursor()
    cursor.execute(query)
    conn.commit()