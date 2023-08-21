// using BackendConCSharpYDotNet.Middlewares;

using BackendConCSharpYDotNet.Services;

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

// La inyección de la dependencia se rebe realizar antes de "var app = builder.Build();"
// El .AddScoped: Es una forma de realiza la inyección de la dependencia, se creará una nueva instancia de la dependecia que se está utilizando
//  pero a nivel de controlador o de a nivel de clase, por lo cual no importa si se inyecta varias veces o en diferentes partes de la clase, se inyectará la misma
//  implementación para ese elemento.
// builder.Services.AddScoped<IHelloWorldService, HelloWorldService>();

//Otra forma de realizar la inyección de la dependencia sin utilizar una interfaz.
builder.Services.AddScoped<IHelloWorldService>(p => new HelloWorldService()); //Esta forma se utiliza cuando tenemos que pasar algun parametro especifico a la clase que se está implementendo.

//Se implementan los servicios de categorias y tareas:
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ITareasService, TareasService>();

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

// app.UseTimeMiddleware();

app.MapControllers();

app.Run();
