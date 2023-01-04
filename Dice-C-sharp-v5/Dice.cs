namespace Puzzle;
class Dice
{
    public int Throw()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }
}

