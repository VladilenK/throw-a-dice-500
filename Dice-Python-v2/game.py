import set

class Game:
    setsLimit = 0
    def __init__(self, setsLimit):
        self.setsLimit = setsLimit
        self.results = []
    
    def play(self):
        for i in range(0,self.setsLimit):
            s = set.Set(100)
            self.results.append(s.play())
        return self.results

