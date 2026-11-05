using GestionCursos.Api.Models;
using GestionCursos.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionCursos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CursosController : ControllerBase
{
    private readonly ICursoService _cursoService;

    public CursosController(ICursoService cursoService)
    {
        _cursoService = cursoService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Curso>> ObtenerTodos()
    {
        return Ok(_cursoService.ObtenerTodos());
    }

    [HttpGet("{id:int}")]
    public ActionResult<Curso> ObtenerPorId(int id)
    {
        var curso = _cursoService.ObtenerPorId(id);
        return curso is null ? NotFound() : Ok(curso);
    }

    [HttpPost]
    public ActionResult<Curso> Agregar(Curso curso)
    {
        var nuevoCurso = _cursoService.Agregar(curso);
        return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevoCurso.Id }, nuevoCurso);
    }

    [HttpPut("{id:int}")]
    public IActionResult Actualizar(int id, Curso curso)
    {
        return _cursoService.Actualizar(id, curso) ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Eliminar(int id)
    {
        return _cursoService.Eliminar(id) ? NoContent() : NotFound();
    }
}
