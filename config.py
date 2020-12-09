import json


class Config():
    def __init__(self):
        self.list = json.load(open('config.json', 'r'))

    def getToken(self) -> str:
        if "token_path" in self.list:
            return open(self.list["token_path"], "r").read()
        else:
            return ""