from random import randrange

class Dice:
    lastValueThrown = 0
    def __init__(self):
        self.lastValueThrown = randrange(1,7)
    def throw(self):
        self.lastValueThrown = randrange(1,7)
        return self.lastValueThrown

