using CineVerse.API.Enums;

namespace CineVerse.API.Models;

public sealed class Genre
{
    public int GenreId { get; set; }
    public string Name { get; set; }
    public GenreDescription Description { get; set; }
    public bool IsActive { get; set; }

    // relationship
    public ICollection<PhysicalMedia> PhysicalMedias { get; set; }
}
