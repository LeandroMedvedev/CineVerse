using CineVerse.API.Models;

namespace CineVerse.API.Interfaces;

public interface IMovieService
{
    Task<Movie> CreateMovieAsync(Movie movie);
    Task<List<Movie>> GetAllMoviesAsync();
    Task<Movie> GetMovieByIdAsync(int id);
    Task<Movie> UpdateMovieAsync(Movie movie);
    Task DeleteMovieAsync(int id);
}
