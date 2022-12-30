
int setsLimit = 1000;
var stopPoint = new Int32();
stopPoint = 100;
var currentPointsSum = new Int32();
Random rnd = new Random();
int dice = rnd.Next(1, 7);
int[] answers = new int[6];
List<int> results = new List<int>();

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
    results.Add(currentPointsSum);
}

// var groupedResults = results.GroupBy(r => r);
results.Sort();
results.GroupBy(r => r);
foreach (var item in results)
{
    Console.WriteLine("Results: {0}", item);
}

Console.WriteLine("Results count: {0}", results.Count);

