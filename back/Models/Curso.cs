namespace GestionCursos.Api.Models;

public class Curso
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Docente { get; set; } = string.Empty;
    public bool Activo { get; set; }
}
