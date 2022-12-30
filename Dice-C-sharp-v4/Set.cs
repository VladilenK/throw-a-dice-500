namespace Puzzle;
class Set
{
    public int StopPoint { get; set; } = 100;
    public int Play()
    {
        var dice = new Dice();
        int currentPointsSum = 0;
        while (currentPointsSum <= StopPoint)
        {
            currentPointsSum += dice.Throw();
        }
        return currentPointsSum;
    }
}

