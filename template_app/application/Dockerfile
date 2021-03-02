FROM python:3.8-alpine

WORKDIR /app

COPY . /app

RUN python -m pip install --upgrade pip
RUN python -m pip install -r requirements.txt

CMD ["python", "app.py"]