namespace CineVerse.API.Models;

public sealed class Serie : PhysicalMedia
{
    public int SerieId { get; set; }
    public bool Awarded { get; set; }
    public string Seasons { get; set; }
    public string Episodes { get; set; }
}
