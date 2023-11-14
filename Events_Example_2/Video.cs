namespace Events_Example_2;

public class Video
{
    public string? Title { get; set; }
    public int? Year { get; set; }

    public override string ToString()
    {
        return $"Video: '{Title ?? "No Title"}', Year: '{(Year < 2900 ? Year : "unknown")}'";
    }
}