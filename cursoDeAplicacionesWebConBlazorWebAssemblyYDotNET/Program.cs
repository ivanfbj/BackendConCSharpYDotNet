using cursoDeAplicacionesWebConBlazorWebAssemblyYDotNET;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuraci�n para HttpClient que es la clase que se encarga de hacer
//  las conexciones a las API's y a servicios externos en general para que la aplicaci�n
//  de Blazor se pueda conectar a ellos y traer datos.
//  La configuraci�n dice que est� utilizando la direcci�n actual en la que est� corriendo la aplicaci�n
//  para poder hacer ese consumo.
//  En pocas palabras: Esto nos permitir�a poder hacer llamado a recursos que se encuentren en la misma
//  app de Blazor.
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//  Se crea una nueva variable para guardar la configuraci�n de la conexi�n a la API de platzi:
//  Se utilizar "builder.Configuration.GetValue<string>("apiUrl")" para obtener un valor del archivo
//      appsettings.json
var apiUrl = builder.Configuration.GetValue<string>("apiUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });

// Se realiza la inyecci�n de dependencia para todos los componentes
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

await builder.Build().RunAsync();
