using Puzzle;

var setStopPoint = 100;
var gamesToPlay = 500;

Console.WriteLine("Let's test game elements:");
var dice = new Dice();
Console.WriteLine(dice.Throw());

var set = new Set();
Console.WriteLine(set.Play());



Console.WriteLine("Let's play the game:");
var game = new Game();
var results = game.Play(gamesToPlay, setStopPoint);
results.Sort();


Console.WriteLine("here are the results sorted:");
foreach (var item in results)
{
    Console.WriteLine("Result: {0}", item);
}

Console.WriteLine("Results count: {0}", results.Count);
Console.WriteLine("Results min: {0}", results.Min());
Console.WriteLine("Results max: {0}", results.Max());

Console.Read();