using CineVerse.API.Interfaces;
using CineVerse.API.Models;

using Microsoft.AspNetCore.Mvc;

namespace CineVerse.API.Controllers;

public sealed class MediaController : BaseAPIController
{
    private readonly IMediaService _mediaService;

    public MediaController(IMediaService mediaService) => _mediaService = mediaService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PhysicalMedia>>> GetAllMediaAsync()
        => await _mediaService.GetAllMediaAsync();
}
