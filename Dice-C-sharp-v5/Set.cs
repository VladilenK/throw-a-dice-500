﻿namespace Puzzle;
class Set
{
    public int stopPoint;

    public Set(int stop)
    {
        stopPoint = stop;
    }
    public int Play()
    {
        var dice = new Dice();
        int currentPointsSum = 0;
        while (currentPointsSum <= stopPoint)
        {
            currentPointsSum += dice.Throw();
        }
        return currentPointsSum;
    }
}

