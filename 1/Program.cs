var birds = new List<int>() {0, 4, 5, 9, 4, 9, 1};

var birdCount = new BirdCount(birds);

birdCount.LastWeek();

System.Console.WriteLine(birds[birds.Count - 1]);

public class BirdCount
{
    List<int> _birds = new List<int>();

    public BirdCount(List<int> birds)
    {
       _birds = birds;   
    }

    public void LastWeek()
    {
        System.Console.Write("[");
        foreach (var bird in _birds)
        {
            System.Console.Write($"{bird}, ");
        }
        System.Console.Write("]"); 
    }
}