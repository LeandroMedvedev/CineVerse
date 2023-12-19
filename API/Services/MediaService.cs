using CineVerse.API.Data;
using CineVerse.API.Interfaces;
using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore;

namespace CineVerse.API.Services;

public sealed class MediaService : IMediaService
{
    private readonly DataContext _context;

    public MediaService(DataContext context) => _context = context;

    public async Task<PhysicalMedia> CreateMediaAsync(PhysicalMedia media)
    {
        _context.PhysicalMedia.Add(media);
        await _context.SaveChangesAsync();

        return media;
    }

    public async Task<List<PhysicalMedia>> GetAllMediaAsync()
        => await _context.PhysicalMedia.ToListAsync();

    public async Task<PhysicalMedia> GetMediaByIdAsync(int id)
        => await _context.PhysicalMedia.FirstOrDefaultAsync(x => x.PhysicalMediaId == id);

    public async Task UpdateMediaAsync(PhysicalMedia media)
    {
        _context.Entry(media).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMediaAsync(int id)
    {
        var media = await _context.PhysicalMedia.FindAsync(id);

        if (media != null)
        {
            _context.PhysicalMedia.Remove(media);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> MediaExistsAsync(string title) 
        => await _context.PhysicalMedia.AnyAsync(x => x.TitleSlug == title.ToLower());
}
