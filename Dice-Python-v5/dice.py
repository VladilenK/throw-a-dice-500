import pandas as pd
from random import randrange

GamesLimit = 1000
StopPoint = 100
gamesResults = []
for i in range(0,GamesLimit):
    gamePointsSum = 0
    while gamePointsSum <= StopPoint :
        gamePointsSum += randrange(1,7)
    gamesResults.append(gamePointsSum)

print(pd.Series(gamesResults).sort_values().value_counts())

