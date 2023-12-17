using CineVerse.API.Helpers;

namespace CineVerse.API.Models;

public sealed class Genre
{
    public int GenreId { get; set; }
    public string Name { get; set; }
    public GenreDefinition Definition { get; set; }

    // public ICollection<PhysicalMedia>? PhysicalMediaList { get; set; }
}
