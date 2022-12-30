namespace Puzzle;
class Game
{
    public int SetsLimit { get; set; } = 1000;
    public int Play()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }

}

