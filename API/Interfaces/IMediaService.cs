using CineVerse.API.Models;

namespace CineVerse.API.Interfaces;

public interface IMediaService
{
    Task<PhysicalMedia> CreateMediaAsync(PhysicalMedia media);
    Task<List<PhysicalMedia>> GetAllMediaAsync();
    Task<PhysicalMedia> GetMediaByIdAsync(int id);
    Task UpdateMediaAsync(PhysicalMedia media);
    Task DeleteMediaAsync(int id);
    Task<bool> MediaExistsAsync(string title);
}
