
int setsLimit = 1000;
int v101s = 0;
int v102s = 0;
int v103s = 0;
var stopPoint = new Int32();
stopPoint = 100;
var currentPointsSum = new Int32();
Random rnd = new Random();
int dice = rnd.Next(1, 7);

for (int i = 0; i < setsLimit; i++)
{
    currentPointsSum = 0;
    while (currentPointsSum <= stopPoint)
    {
        dice = rnd.Next(1, 7);
        currentPointsSum += dice;
        // Console.WriteLine("Dice is {0} and the sum is {1}", dice, currentPointsSum);
    }
    // Console.WriteLine("This set's sum is {0}", currentPointsSum);
    if (currentPointsSum == 101) { v101s = v101s + 1; }
    if (currentPointsSum == 102) { v102s += 1; }
    if (currentPointsSum == 103) { v103s++; }
}
Console.WriteLine("101 counted {0} times", v101s);
Console.WriteLine("102 counted {0} times", v102s);
Console.WriteLine("103 counted {0} times", v103s);







