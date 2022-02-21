import datetime

import Exploid
from Product import Product
from State import State
from datetime import date


class Task:
    def __init__(self, name: str, exploid: Exploid, period: int, priority: int):
        self.name = name
        self.exploid: Exploid = exploid
        self.period: int = period
        self.priority: int = priority
        self.state: State = State.WAITING
        self.time: datetime = None

    def __str__(self):
        return "[" + self.name + "]: State:" + str(self.state) + " at " + self.time

    def getState(self):
        now = date.today()
        if self.state is State.RUNNING:
            if self.time + self.exploid.execution_time < now: # si time + executiontime est plus ancien que maintenant
                self.state = State.BLOCKED
                self.time = now # set le temps par le début du cooldown (period)
        elif self.state is State.BLOCKED:
            if self.time + datetime.timedelta(seconds=self.period) < now: # si time + period est plus ancien que maintenant
                self.state = State.WAITING
        return self.state

