using GestionCursos.Api.Models;

namespace GestionCursos.Api.Services;

public interface ICursoService
{
    IEnumerable<Curso> ObtenerTodos();
    Curso? ObtenerPorId(int id);
    Curso Agregar(Curso curso);
    bool Actualizar(int id, Curso curso);
    bool Eliminar(int id);
}
