using cursoDeFundamentosDeEntityFramework;
using cursoDeFundamentosDeEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Esta configuraci�n solo sirve para base de datos en Memoria
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));

// Configuraci�n del servicio para conectarse a SQL Server.
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("connectionTareas"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{

    //C�digo que crear� la base de datos y verificar� que la base de datos se pueda crear
    // Y retorna si logr� o no crear la base de datos
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());

});

app.MapGet("/api/tareas", async ([FromServices] TareasContext dbContext) =>
{
    // Dentro del contexto de Entity Framework se tiene la colecci�n de Tareas
    // Dicha colecci�n representa la colecci�n de datos que existe dentro de la base de datos.
    return Results.Ok(dbContext.Tareas);
});

app.MapGet("/api/tareasFiltradasyCategoria", async ([FromServices] TareasContext dbContext) =>
{
    // Se puede utilizar LINQ para realizar filtros seg�n se requiera.
    //return Results.Ok(dbContext.Tareas.Where(t => t.PrioridadTarea == cursoDeFundamentosDeEntityFramework.Models.Prioridad.Baja));

    // Con el m�todo "Include" se puede incluir la informaci�n adicional con la que quiero que se muestre
    // la Tarea, en este caso la informaci�n de la categoria asociada a la Tarea
    return Results.Ok(dbContext.Tareas.Include(c => c.Categoria).Where(t => t.PrioridadTarea == cursoDeFundamentosDeEntityFramework.Models.Prioridad.Baja));
});

app.MapPost("/api/tareas", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea) =>
{
    tarea.TareaId = Guid.NewGuid();
    tarea.FechaCreacion = DateTime.Now;

    await dbContext.AddAsync(tarea);
    
    // Esta es otra forma de insertar una tarea con Entity Framework.
    //await dbContext.Tareas.AddAsync(tarea);

    await dbContext.SaveChangesAsync();

    return Results.Ok();
});

app.MapGet("/api/categorias", async ([FromServices] TareasContext dbContext) =>
{
    // Dentro del contexto de Entity Framework se tiene la colecci�n de Categorias
    // Dicha colecci�n representa la colecci�n de datos que existe dentro de la base de datos.
    return Results.Ok(dbContext.Categorias);
});

app.Run();
