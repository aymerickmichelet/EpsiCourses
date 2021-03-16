types = {"+": "ADD", "-": "REMOVE", "X": "DONE", "O": "TODO"}


def getActionTypeFromCommand(command) -> str:
    global types
    action = command.split(" ", 1)[0].upper()

    for t in types:
        if action == t:
            return types[t]
    return None


def getCommand(command) -> str:
    return command.split(" ", 1)[1]


class Action:
    def __init__(self, command):
        self.type = getActionTypeFromCommand(command)
        self.command = getCommand(command) if self.type is not None else None
