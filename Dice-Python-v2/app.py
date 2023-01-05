import pandas as pd
from random import randrange
import sys
import dice, set, game

d = dice.Dice()
print(d.lastValueThrown)
print(d.throw())
print(d.lastValueThrown)

s = set.Set(100)
print(s.play())

g = game.Game(1000)
gamePlayed = g.play()
print("Game Played:")
print(gamePlayed)

print("Pandas Series:")
results = pd.Series(gamePlayed).sort_values()
print(results.head())

print("Results grouped (values counted) :")
print(results.value_counts())
