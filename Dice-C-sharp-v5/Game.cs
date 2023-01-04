namespace Puzzle;
public class Game
{
    // public int SetsLimit { get; set; } = 1000;
    public List<int> Play(int limit, int stopPoint)
    {
        List<int> results = new List<int>();
        for (int i = 0; i < limit; i++)
        {
            var set = new Set(stopPoint);
            results.Add(set.Play());
        }

        return results;

    }

}

