using GestionCursos.Api.Models;

namespace GestionCursos.Api.Services;

public class CursoService : ICursoService
{
    private readonly List<Curso> _cursos =
    [
        new() { Id = 1, Nombre = "Desarrollo de Aplicaciones Web", Docente = "Ana Torres", Activo = true },
        new() { Id = 2, Nombre = "Base de Datos", Docente = "Carlos Mena", Activo = true },
        new() { Id = 3, Nombre = "Programacion Orientada a Objetos", Docente = "Maria Lopez", Activo = false }
    ];

    public IEnumerable<Curso> ObtenerTodos() => _cursos;

    public Curso? ObtenerPorId(int id) => _cursos.FirstOrDefault(curso => curso.Id == id);

    public Curso Agregar(Curso curso)
    {
        curso.Id = _cursos.Count > 0 ? _cursos.Max(item => item.Id) + 1 : 1;
        _cursos.Add(curso);
        return curso;
    }

    public bool Actualizar(int id, Curso curso)
    {
        var existente = ObtenerPorId(id);
        if (existente is null)
        {
            return false;
        }

        existente.Nombre = curso.Nombre;
        existente.Docente = curso.Docente;
        existente.Activo = curso.Activo;
        return true;
    }

    public bool Eliminar(int id)
    {
        var curso = ObtenerPorId(id);
        return curso is not null && _cursos.Remove(curso);
    }
}
