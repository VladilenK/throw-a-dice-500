using Puzzle;

var set = new Set();
set.StopPoint = 500;
Console.WriteLine(set.Play());





// var currentPointsSum = new Int32();
// Random rnd = new Random();
// int dice = rnd.Next(1, 7);
// List<int> results = new List<int>();

// for (int i = 0; i < setsLimit; i++)
// {
//     currentPointsSum = 0;
//     while (currentPointsSum <= stopPoint)
//     {
//         dice = rnd.Next(1, 7);
//         currentPointsSum += dice;
//         // Console.WriteLine("Dice is {0} and the sum is {1}", dice, currentPointsSum);
//     }
//     // Console.WriteLine("This set's sum is {0}", currentPointsSum);
//     results.Add(currentPointsSum);
// }

// var answers = results.GroupBy(x => x)
//                            .Select(grp => new { number = grp.Key, count = grp.Count() })
//                            .ToArray();

// foreach (var item in answers)
// {
//     Console.WriteLine("Results: {0}", item);
// }

// Console.WriteLine("Results count: {0}", answers.Length);

