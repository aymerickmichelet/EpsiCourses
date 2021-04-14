FROM python:3

# same route than 'codecontainer' in script.sh
WORKDIR /program

ENTRYPOINT [ "python3", "/program/main.py" ]
