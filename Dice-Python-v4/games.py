import game

class Games:
    setsLimit = 0
    def __init__(self, setsLimit):
        self.setsLimit = setsLimit
        self.results = []
    
    def play(self):
        for i in range(0,self.setsLimit):
            g = game.Game(100)
            self.results.append(g.play())
        return self.results

