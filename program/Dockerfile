FROM python:3

WORKDIR /program

RUN apt-get upgrade && apt-get update
RUN apt-get install python3-pip -y
RUN pip3 install mysql-connector-python
RUN pip3 install Flask
RUN pip3 install flask-cors

CMD ["python3", "/program/app.py"]