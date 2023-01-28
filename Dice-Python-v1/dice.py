import pandas as pd
from random import randrange
import sys

SetsLimit = 10000
StopPoint = 100
v1 = v2 = v3 = 0
for i in range(0,SetsLimit):
    pointsSum = 0
    while pointsSum <= StopPoint :
        pointsSum += randrange(1,7)
    if pointsSum == 101:
        v1 += 1
    if pointsSum == 102:
        v2 += 1
    if pointsSum == 103:
        v3 += 1

print("101:", v1, "%.2f" %  (v1/SetsLimit*100), "%")
print("102:", v2, "%.2f" %  (v2/SetsLimit*100), "%")
print("103:", v3, "%.2f" %  (v3/SetsLimit*100), "%")

a = ['Apple', 'Bananas', 'Pears']
s = pd.Series(a)
print(s)