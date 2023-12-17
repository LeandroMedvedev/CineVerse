namespace CineVerse.API.Models;

public sealed class Movie : PhysicalMedia
{
    public int MovieId { get; set; }
    public bool BasedOnRealFacts { get; set; }
    public bool BasedOnBooks { get; set; }
    public bool Dubbed { get; set; }
}
