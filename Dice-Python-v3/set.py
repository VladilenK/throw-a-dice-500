import dice

class Set:
    stopPoint = 0
    pointsSum = 0
    def __init__(self, stopPoint):
        self.stopPoint = stopPoint
    def play(self):
        d = dice.Dice()
        while self.pointsSum <= self.stopPoint:
            self.pointsSum += d.throw()
        return self.pointsSum


