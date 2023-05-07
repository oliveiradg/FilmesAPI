using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;
[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<FilmesModel> filmes = new List<FilmesModel>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody]FilmesModel filme)
    {   
        filme.Id = id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(RecuperarFilmes), 
            new { id = filme.Id },
            filme);
        
                   

    }


    [HttpGet]

    public IEnumerable<FilmesModel> RecuperarFilmes([FromQuery]int skip = 0,
        [FromQuery] int take = 10)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult reucperaFilmePorId(int id)
    {
     var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
}
