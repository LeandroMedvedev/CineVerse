using CineVerse.API.Data;
using CineVerse.API.Helpers;
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

    public async Task UpdateMovieAsync(Movie movie)
    {
        _context.Entry(movie).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMovieAsync(Movie movie)
    {
        _context.Movie.Remove(movie);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> MovieExistsAsync(string title)
        => await _context.PhysicalMedia.AnyAsync(x => x.Title == Text.CapitalizeWords(title));

    public async Task<Movie> MovieByIdAsync(int id)
        => await _context.Movie.FindAsync(id);
}
