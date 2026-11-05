using GestionCursos.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ICursoService, CursoService>();

var app = builder.Build();

app.MapControllers();

app.Run();
