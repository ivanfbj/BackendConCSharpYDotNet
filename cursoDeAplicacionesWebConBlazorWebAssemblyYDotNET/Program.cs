using cursoDeAplicacionesWebConBlazorWebAssemblyYDotNET;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuración para HttpClient que es la clase que se encarga de hacer
//  las conexciones a las API's y a servicios externos en general para que la aplicación
//  de Blazor se pueda conectar a ellos y traer datos.
//  La configuración dice que está utilizando la dirección actual en la que está corriendo la aplicación
//  para poder hacer ese consumo.
//  En pocas palabras: Esto nos permitiría poder hacer llamado a recursos que se encuentren en la misma
//  app de Blazor.
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//  Se crea una nueva variable para guardar la configuración de la conexión a la API de platzi:
//  Se utilizar "builder.Configuration.GetValue<string>("apiUrl")" para obtener un valor del archivo
//      appsettings.json
var apiUrl = builder.Configuration.GetValue<string>("apiUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });

// Se realiza la inyección de dependencia para todos los componentes
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

await builder.Build().RunAsync();
