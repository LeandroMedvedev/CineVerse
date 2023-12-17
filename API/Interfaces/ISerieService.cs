using CineVerse.API.Models;

namespace CineVerse.API.Interfaces;

public interface ISerieService
{
    Task<Serie> CreateSerieAsync(Serie serie);
    Task<List<Serie>> GetAllSeriesAsync();
    Task<Serie> GetSerieByIdAsync(int id);
    Task<Serie> UpdateSerieAsync(Serie serie);
    Task DeleteSerieAsync(int id);
}
