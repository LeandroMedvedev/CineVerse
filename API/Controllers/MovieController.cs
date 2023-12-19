using CineVerse.API.Helpers;
using CineVerse.API.Interfaces;
using CineVerse.API.Models;

using Microsoft.AspNetCore.Mvc;

namespace CineVerse.API.Controllers;

public sealed class MovieController : BaseAPIController
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService) => _movieService = movieService;

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovieByIdAsync(int id)
    {
        var movie = await _movieService.GetMovieByIdAsync(id);

        if (movie == null) return NotFound(new { Message = "Filme não encontrado" });

        return StatusCode(200, movie);
    }

    [HttpPost("register")]
    public async Task<ActionResult<Movie>> CreateMovieAsync([FromBody] Movie data)
    {
        if (await _movieService.MovieExistsAsync(data.Title)) return Conflict(
            new { Message = "O filme já existe no banco de dados" }
        );

        data.Title = Text.CapitalizeWords(data.Title);
        
        await _movieService.CreateMovieAsync(data);

        return StatusCode(201, data);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateMovieAsync([FromBody] Movie data, int id)
    {
        var movie = await _movieService.MovieByIdAsync(id);

        if (movie == null) return NotFound(new { Message = "Filme não encontrado" });

        data.Title = Text.CapitalizeWords(data.Title);
        data.Classification = data.Classification.ToLower();
        
        await _movieService.UpdateMovieAsync(data);

        return StatusCode(200);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteMovieAsync(int id)
    {
        var movie = await _movieService.MovieByIdAsync(id);

        if (movie == null) return NotFound(new { Message = "Filme não encontrado" });

        await _movieService.DeleteMovieAsync(movie);

        return StatusCode(204);
    }
}
