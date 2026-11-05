# Esqueleto funcional - Gestion de Cursos

Proyecto separado en las dos aplicaciones que solicita la consigna:

- `front`: Angular 22 con componentes standalone, `CommonModule`, `FormsModule` y Bootstrap.
- `back`: ASP.NET Core Web API con modelo, servicio, controlador y datos en memoria.

## Ejecutar el frontend

```bash
cd front
npm install
npm start
```

Abrir `http://localhost:4200`.

## Ejecutar el backend

```bash
cd back
dotnet run
```

La API queda disponible en `http://localhost:5050/api/cursos`.

El archivo `back/GestionCursos.postman_collection.json` se puede importar directamente en Postman e incluye GET, GET por id, POST, PUT y DELETE. `back/GestionCursos.Api.http` contiene las mismas pruebas para Visual Studio o VS Code.

## Importante

El frontend usa una lista local porque la consigna indica que el consumo real de la API mediante `HttpClient` no es obligatorio. El backend mantiene su propia lista en memoria y la reinicia al detener la aplicacion.

Cada grupo debe cambiar nombres, textos, colores y datos de ejemplo, comprender el codigo y preparar sus propias evidencias y repositorios.
