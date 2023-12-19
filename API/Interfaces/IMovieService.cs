using CineVerse.API.Models;

namespace CineVerse.API.Interfaces;

public interface IMovieService
{
    Task<Movie> CreateMovieAsync(Movie movie);
    Task<List<Movie>> GetAllMoviesAsync();
    Task<Movie> GetMovieByIdAsync(int id);
    Task UpdateMovieAsync(Movie movie);
    Task DeleteMovieAsync(Movie movie);
    Task<bool> MovieExistsAsync(string title);
    Task<Movie> MovieByIdAsync(int id);
}
