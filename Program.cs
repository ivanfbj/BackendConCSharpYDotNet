// using BackendConCSharpYDotNet.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Para activar el CORS y poder consumir el API desde una app de front
// builder.Services.AddCors(options => 
// {
//     options.AddPolicy("NuevaPolitica", app => {
//         app.AllowAnyOrigin()
//         .AllowAnyHeader()
//         .AllowAnyMethod();
//     };)
// }
// )

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UserCors("NuevaPolitica"); // Esta relacionado con el tema de seguridad para permitir quien la puede o no utilizar.

app.UseAuthorization();

// Middleware que permite agregar una pagina de bienvenida, cada vez que se ingrese a la API.
// app.UseWelcomePage();

app.UseTimeMiddleware();

app.MapControllers();

app.Run();
