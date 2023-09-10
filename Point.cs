namespace ITLOB;

public record struct Point(double X, double Y)
{
    public string SVG => $"{X},{Y}";
}