using cursoDeFundamentosDeEntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Esta configuración solo sirve para base de datos en Memoria
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));

// Configuración del servicio para conectarse a SQL Server.
builder.Services.AddSqlServer<TareasContext>("Data Source=localhost\\sqlexpress;Initial Catalog=TareasDb;user id=sa; password=passwordSQL_sa; Trust Server Certificate= True");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{

    //Código que creará la base de datos y verificará que la base de datos se pueda crear
    // Y retorna si logró o no crear la base de datos
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());

});

app.Run();
