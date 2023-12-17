using CineVerse.API.Data;
using CineVerse.API.Interfaces;
using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore;

namespace CineVerse.API.Services;

public sealed class MovieService : IMovieService
{
    private readonly DataContext _context;

    public MovieService(DataContext context) => _context = context;

    public async Task<Movie> CreateMovieAsync(Movie movie)
    {
        _context.Movie.Add(movie);
        await _context.SaveChangesAsync();

        return movie;
    }

    public async Task<List<Movie>> GetAllMoviesAsync()
        => await _context.Movie.ToListAsync();

    public async Task<Movie> GetMovieByIdAsync(int id)
        => await _context.Movie.FirstOrDefaultAsync(x => x.MovieId == id);
    
    public async Task<Movie> UpdateMovieAsync(Movie movie)
    {
        _context.Entry(movie).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return movie;
    }

    public async Task DeleteMovieAsync(int id)
    {
        var movie = await _context.Movie.FindAsync(id);
        if (movie != null)
        {
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
        }
    }
}
