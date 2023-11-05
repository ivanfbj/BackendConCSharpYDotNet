# [LO QUE TIENES QUE SABER como Programador Backend (OBLIGATORIO)](https://www.youtube.com/watch?v=2TY_TkjRUp0)

Esta rama es independiente de las otras, las otras ramas están enfocadas en una ruta de aprendizaje de [Platzi](https://platzi.com).

Esta rama está enfocada en el vídeo [LO QUE TIENES QUE SABER como Programador Backend (OBLIGATORIO)](https://www.youtube.com/watch?v=2TY_TkjRUp0) del canal de [Youtube de hdeleon.net](https://www.youtube.com/@hdeleonnet).

La idea de esta rama es complementar los conocimientos que tengan que ver y esten relacionados con el mundo de Backend en C# y .NET.

Los contenidos de esta rama serán los mismos del video:

- 00:00 Introducción
- 03:00 Creación del proyecto
- 04:57 Patrón de Arquitectura MVC
- 05:30 Controladores
- 07:00 Rutas
- 09:40 Modelos
- 13:00 Swagger
- 15:10 Respuestas HTTP
- 21:00 Creación de bibliotecas de clases
- 22:15 Entity Framework
- 27:00 Referencias Bibliotecas de clases
- 28:30 Creación de Base de Datos
- 31:27 Inyección de dependencia
- 33:11 Creación de base de datos en ejecución
- 37:00 Accediendo a base de datos desde controlador

## Introducción

Se abordarán lo temas mínimos que debe conocer y manejar un desarrollador backend independientemente del lenguaje de programación que use, ya que los conceptos aplican para todos. Para los ejemplos se utilizará código C# en .NET.

## Creación del proyecto

Se creará un proyecto desde visual studio con la plantilla `ASP.NET Core Web API`, luego de colocar el nombre del proyecto se debe seleccionar la opción `Usar controladores (desactivar para usar API mínimas)` para luego explicar otros conceptos, para estos temas se trabajará con el Framework `.NET 7.0`.

El proyecto que se crea ya tiene una base, se borra la clase y el controlador llamados `WeatherForecast.cs` y `WeatherForecastController.cs` ya que no se requieren.

## Patrón de Arquitectura MVC

Los controladores son un concepto de capa.

MVC (Modelo-Vista-Controlador) es un patrón arquitectonico que nace en los años 70's, representa una forma anstracta, una forma de capas de responsabilidades; en este caso el controlador va a recibir lo que se requiere hacer en el programa y el controlador es el que va a responder, en este caso al ser Backend, se responderá con un JSON.

## Controladores

En caso de estar trabajando con desarrollos web de MVC completos la vista va a responder con un HTML.

Hay 2 tipos de controlador en ASP.NET:

1. El controlade MVC que regresa una vista.
2. El controlador de API.

Para este ejemplo que es solamente Backend se da clic derecho sobre la carpeta `Controllers`-> Agregar -> Controlador -> API -> `Controlador de API: en blanco`, se crea con el nombre `BeerController.cs`.

El concepto de Controller se utiliza en otros tipos de tecnología.

## Rutas

Parte de las rutas es el dominio o localHost, un puerto que se asigna automáticamente, luego incluye la ruta que se crea en el controlador

```C#
[Route("api/[controller]")]
```

Lo métodos que se crean pueden retornar un tipo de datos nativo y adicionalmente se le incluye un tipo de petición de HTTP en este caso `[HttpGet]`

HttpGet es un tipo de verbo para las solicitudes HTTP, los más utilizados son HttpGet, HttpPost, HttpPut y HttpDelete.

## Modelos

Los controladores tienes la responsabilidad de recibir las solicitudes, procesarlas y retornar algo.

Los modelos son la parte que moldea la información con la cual se va a trabajar.

Se crea la carpeta `Models` y dentro la clase `Beer.cs` con sus respectivas propiedades.

En el controlador se crea un nuevo método y en las rutas se puede personalizar las rutas, el primer método es la ruta por defecto, el segundo método ingresa por la ruta especificada en el código.

## Swagger

Swagger nos permite documentar cada uno de los puntos de acceso que se crean en el controlador, Swagger se encuentra incluido en .NET.

Al momentos de ejecutar el proyecto se inicializa la venta de Swagger con cada uno de los accesos que existen.

También genera una estructura en JSON de toda la información, los modelos creados, tipos de peticiones, resultado, entre otros.

## Respuestas HTTP

Cuando se está utilizando un controlador que tenga un `IActionResult` es porque se puede retornar diferentes tipos de respuestas, y sobre todo tipo de respuesta de estados de HTTP.

Cuando se retorna un `Ok`, se está retornando un tipo de HTTP con código 200, el 200 es un tipo de respuesta HTTP.

Además del `Ok` también está el `BadRequest` que retorna un tipo de HTTP con código 400.

Hay diferentes rangos de códigos que están documentados y que se pueden utilizar en el código para retornar diferentes estados.

Estos código se usan para indicarle al Frontend que tipo de respuesta se le está entregando desde el Backend y se pueda controlar en el Front.

```C#
public IActionResult Add(Beer beer)
{
    if (beer.Name.Equals(""))
    {
        return BadRequest("No se envio la información");
    }

    return Ok(beer);
}
```

A nivel de código se crea un método que va a recibir un JSON y válida si el nombre está vacio gebera el `BadRequest` de lo contrario retorna el objeto que recibio.

## Creación de bibliotecas de clases

Directamente en la solución del proyecto se da clic derecho -> Agregar -> Nuevo proyecto y en las plantilla de proyecto se busca y se selecciona `Biblioteca de clases`, una vez creado el nuevo proyecto se modifica el nombre de la clase por defecto que se crea, `BackendBarContext`

Las bibliotecas de clases son una herramienta poderosa para promover la reutilización de código, la modularidad y la organización en proyectos de .NET. Pueden ser utilizadas para encapsular funcionalidades específicas y proporcionar una interfaz clara para interactuar con ellas desde otros proyectos.

## Entity Framework

Un ORM es mapeador de base de datos el cual te permite trabajar con una base de datos como si fueran objetos de programación orientada a objetos.

Para trabajar con un ORM se tiene la opción Entity Framework en .NET.

En el proyecto `DB` se da clic derecho en `Dependencias` -> Administrar paquetes NuGet, en la nueva pestaña que se habilita se da en la opción de "Examinar" se busca "entity framework" y se selecciona para instalar los paquetes que se llaman `Microsoft.EntityFrameworkCore.SqlServer` y `Microsoft.EntityFrameworkCore.Tools`.

Una vez instalado estos dos paquete se puede utilizar "Entity Framework" en la biblioteca de clases. Est

En la clase `BackendBarContext` se debe poner a hereda de la clase `DbContext` que se importa desde `using Microsoft.EntityFrameworkCore;`, adicionalmente se crea un constructor de la clase ejemplo:

```C#
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BackendBarContext : DbContext
    {
        public BackendBarContext(DbContextOptions<BackendBarContext> options) : 
            base(options)
        {

        }
    }
}
```

Luego se crea la clase `Beer.cs` que tendrá la clase con los atributos que se creará en la base de datos, al primer atributo se le especifica que será Primary Key y será un Identity.

Luego regresamos a `BackendBarContext` para especificar que la base de datos tendrá objetos de tipo `Beer.cs`, para lo cual se crea un:

```C#
public DbSet<Beer> Beers { get; set; }
```

Code First: Se comienza escribiendo clases de entidades en código C#. Estas clases representan las entidades que serán almacenadas en la base de datos. Luego, a través de convenciones y configuraciones específicas, Entity Framework puede generar automáticamente la base de datos y las tablas correspondientes a partir de esas clases.

## Referencias Bibliotecas de clases

Luego de realizar la configuración de la Biblioteca de clases es necesario ir al primer proyecto `BackendApp`, ir a dependencia y dar clic derecho -> agregar referencia del proyecto y seleccionar el proyecto `DB`, se selecciona y luego aceptar.

De esta manera se puede trabajar con la biblioteca de clases en el primer proyecto.

En el primer poyecto en las dependencias se debe instalar `Microsoft.EntityFrameworkCore.Tools` para poder utilizar las herramientas de Entity Framewor, luego ir a la solución y clic derecho Compilar.

Con la biblioteca de clase te permite tener varios proyectos que vayan a la misma base de datos y de esta manera no tener que repetir el código.

## Creación de Base de Datos

En SQL Server se crea una nueva base de datos llamada `BackendBar`, luego en el archivo `appsetings.json` del proyecto `BackendApp` se crea la cadena de conexión a la base de datos:

```JSON
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      //Conexión de Windows
      "BackendBar": "Server=localhost\\sqlexpress; Database=BackendBar; Trusted_Connection=True; Trust Server Certificate= True"
  }
}
```

## Inyección de dependencia

En el archivo `Program.cs` se procede a inyectar el contexto para ser usado en todos los controladores.

La inyección de dependencias te permite que tus objetos los puedas obtener por medio del constructor o en los métodos para que la responsabilidad de la creación este por fuera de dicho constructor o método; esto se debe a que en caso de que se llegue a requierir realizar un cambio sea solamente en `Program.cs`.

```C#
builder.Services.AddDbContext<BackendBarContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BackendBar"));
});
```

De esta manera ya .NET sabe que la configuración que se realizó en GetConnectionString(`"BackendBar"`) va a ir en el contexto de base de datos.

El contexto en Entity Framwork viene a ser la representación de la base de datos, de esta manera ya se podra obtener Entity Framework en todos los controladores.

