"""Interpret results with Pandas... """
import pandas as pd
import games, game, dice

d = dice.Dice()
print(d.lastValueThrown)
print(d.throw())
print(d.lastValueThrown)

s = game.Game(100)
print(s.play())

g = games.Games(1000)
gamesPlayed = g.play()
print("Game Played:")
print(gamesPlayed)

results = pd.Series(gamesPlayed).sort_values()
print("Results grouped (values counted) :")
print(results.value_counts())

