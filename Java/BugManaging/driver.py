import pyodbc
from flask import Flask, request, jsonify

app = Flask(__name__)

conn_str = "".join(open("api.txt").readlines())

def get_db_connection():
    print("connecting...")
    conn = pyodbc.connect(conn_str)
    print("connected!")
    return conn

@app.route('/reports', methods=['GET'])
def get_reports():
    conn = get_db_connection()
    cursor = conn.cursor()
    reports = cursor.execute("SELECT * FROM Reports").fetchall()
    columns = cursor.execute("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'Reports'").fetchall()
    columns = [columns[i][3] for i in range(len(columns))]

    conn.close()

    # turn it into a more json-ifiable object 
    all_reports = {"reports":[]}
    for item in reports:
        report = {}
        for i in range(len(columns)):
            report[columns[i]] = item[i]
        
        all_reports["reports"].append(report)

    return jsonify(all_reports)


if __name__ == '__main__':
    app.run()