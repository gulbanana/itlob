namespace ITLOB.State;

public class Game
{
    public int Width { get; set; }
    public int Height { get; set; }

    public double Counter { get; set; }
    public double Fraction { get; set; }

    public int? Focus;

    public void Tick(TimeSpan elapsed)
    {
        Counter += elapsed.TotalSeconds;
        Fraction = Counter - Math.Round(Counter) + 0.5;
    }
}