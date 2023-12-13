namespace CineVerse.API.Models;

public sealed class Movie : PhysicalMedia
{
    public bool BasedOnRealFacts { get; set; }
    public bool BasedOnBooks { get; set; }
    public bool Dubbed { get; set; }
}
