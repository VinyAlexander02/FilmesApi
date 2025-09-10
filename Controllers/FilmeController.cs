namespace FilmesApi.Controllers;

using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models; 
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class FilmController : ControllerBase
{
    private FilmContext _context;
    private IMapper _mapper;

    public FilmController(FilmContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddFilm([FromBody] CreateFilmDto filmDto)
    {
        Film film = _mapper.Map<Film>(filmDto);
        _context.Films.Add(film);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetFilmId), new { id = film.Id }, film);
    }

    [HttpGet]
    public List<Film> GetFilms([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Films.Skip(skip).Take(take).ToList();
    }

    [HttpGet("{id}")]
    public IActionResult GetFilmId(int id)
    {
        var film = _context.Films.FirstOrDefault(f => f.Id == id);
        if (film == null) return NotFound();
        return Ok(film);
    }
}