namespace ITLOB.State;

public class Game
{
    public int Width { get; set; }
    public int Height { get; set; }

    public double Counter { get; set; }

    public void Tick(TimeSpan elapsed)
    {
        Counter += elapsed.TotalSeconds;
    }
}