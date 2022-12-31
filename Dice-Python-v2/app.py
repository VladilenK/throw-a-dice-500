from random import randrange
import sys
import dice, set, game


d = dice.Dice()
print(d.lastValueThrown)
print(d.throw())
print(d.lastValueThrown)

s = set.Set(100)
print(s.play())

g = game.Game(10)
print(g.play())





