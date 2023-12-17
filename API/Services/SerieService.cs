using CineVerse.API.Data;
using CineVerse.API.Interfaces;
using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore;

namespace CineVerse.API.Services;

public sealed class SerieService : ISerieService
{
    private readonly DataContext _context;

    public SerieService(DataContext context) => _context = context;

    public async Task<Serie> CreateSerieAsync(Serie serie)
    {
        _context.Serie.Add(serie);
        await _context.SaveChangesAsync();

        return serie;
    }

    public async Task<List<Serie>> GetAllSeriesAsync()
        => await _context.Serie.ToListAsync();

    public async Task<Serie> GetSerieByIdAsync(int id)
        => await _context.Serie.FirstOrDefaultAsync(x => x.SerieId == id);
    
    public async Task<Serie> UpdateSerieAsync(Serie serie)
    {
        _context.Entry(serie).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return serie;
    }

    public async Task DeleteSerieAsync(int id)
    {
        var serie = await _context.Serie.FindAsync(id);

        if (serie != null)
        {
            _context.Serie.Remove(serie);
            await _context.SaveChangesAsync();
        }
    }
}
