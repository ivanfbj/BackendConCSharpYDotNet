# Curso de Aplicaciones Web con Blazor WebAssembly y .NET

Potencia tu carrera como programador .NET FullStack con .NET. y Blazor. Aprende sobre WebAssembly y como se aplica en Blazor para crear aplicaciones con C# y HTML sin depender de JavaScript. Analiza la arquitectura, estructura y diferentes funcionalidades que puedas agregar a tus proyectos.

## Clase 1 - Presentación

Se revisaran conceptos de:

- Blazor.
- WebAssembly.
- Diferencias estre Blazor Server y Blazor WebAssembly.
- Arquitectura y estructura de los componentes en Blazor y las diferentes funcionalidades.

## Clase 2 - Prerrequisitos

- Conocimiento en C# y .NET
- Visual Code o Visual Studio
- Conocimientos sobre desarrollo web (HTML, CSS, JavaScript)
- .NET 6 0 superior.

## Clase 3 - ¿Qué es WebAssembly y Blazor?

**WebAssembly:**

- Nuevo estándar web que aparece por primera vez en 2015.
- Diseñado inicialmente para C/C++.
- Permite a lenguajes compilados ejecutarse en el navegador (Rust, C++, Go, C#).
- Extensiones .wast, .wasm
- Puede trabajar junto con JavaScript.

Es muy bueno trabajando con grandes cantidade de datos y procesando gran información, Javascript es muy buenos interactuando con el CSS y con el navegador.

**Caso de éxito con WebAssembly**:

- Figma
- AMPED Studio
- Google earth

**Blazor**:

- Nueva tecnología para el desarrollo web. (Cambia un poco el paradigma que se tenia con ASP.NET)
- Basado en componentes.
- Sintaxis C# + HTML.
- Open source y multiplataforma.
- Muchas librerías y apoyo de la comunidad.
- Puede trabajar junto con JavaScript.

**Blazor WebAssembly VS Blazor Server:**

|||
|--------------------------|-------------------------|
|Se ejecuta en el navegador|Se ejecuta en el servidor|
|Utiliza Web Assembly para hospedaje en el navegador|Utiliza SignalR para sincronizar los cambios.|
|Mejor experiencia en la web|Excelente para manipular grandes cantidades de datos y lógica de negocio|
|Soporta progressive web apps (PWA)|

**Evolución de blazor en el tiempo**:

![Evolución 1](images/Evolucion_1.png)
![Evolución 2](images/Evolucion_2.png)
![Evolución 3](images/Evolucion_3.png)

Enlaces:
[Made with WebAssembly](https://madewithwebassembly.com/)

Lecturas recomendadas:

- [Made with WebAssembly](https://madewithwebassembly.com/)
- [ASP.NET Core Blazor | Microsoft Learn](https://docs.microsoft.com/en-us/aspnet/core/blazor)

## Clase 4 - Creando un proyecto de Blazor en Visual Studio

Revisar en Visual Studio que se tenga instalada la carga de trabajo de `ASP.NET and web development` en la opcion de `Herramientas -> Obtener herramientas y características...`

Luego en las plantillas de un nuevo proyecto en Visual Studio se selecciona la opción de `Aplicación Blazor para WebAssembly` (Blazor WebAssembly App) una vez asignado el nombre del proyecto y la ruta donde quedará almacenado.

En la información adicional se usa:

- Framework: .NET 6.0
- Authentication de campo: Ninguno
- Configurar para HTTPS.
- Aplicación web progresiva

Ya con esto se puede crear el proyecto.

Al ejecutar el proyecto este abre una página web de demo que genera el proyecto y que será la base para comenzar a trabajar.

La funcionalidad de recarga activa permite que la aplicación cargue y actualice los cambios cada vez que se van guardando los archivos.

## Clase 5 - Creando un proyecto de Blazor con el CLI

Por el CLI una vez ubicado en la carpeta donde se quiere crear el proyecto se utiliza el comando el proyecto

```Bash
dotnet new blazorwasm
```

Comando para compilar:

```Bash
dotnet build
```

Comando para ejecutar el proyecto:

```Bash
dotnet run
```

Comando para tener la recarga activa:

```Bash
dotnet watch
```

## Clase 6 - Analizando extensiones de Visual code para blazor

- C#
- Blazor Snippet Pack
- Blazor Snippets

## Clase 7 - Estructura de componentes y arquitectura en Blazor

- `Program.cs`: Estructura general para poder ejecutar el proyecto, en este archivo se realizará la configuración de los servicios o dependencias que se van a inyectar en la aplicación.

- `cursoDeAplicacionesWebConBlazorWebAssemblyYDotNET.csproj`: archivo de proyecto donde está el SDK de Blazor Web Assembly, verisón de .Net, paquetes de WebAseembly que se utilizan para la ejecución del proyecto.

- `App.razor`: archivo base que va a contener toda la aplica y toda la estructura de componentes que se van a estar creaciondo, normalmente este archivo no se modifica, lo que se hace es extenderlo y agregarle nuevas configuraciones y propiedades.

- `_Imports.razor`: contiene las declaraciones de `using` que se van a utilizar en los componentes de la aplicación, con esto no se tendría que ir a cada componente y colocar el `using` correspondiente.

- Carpeta `wwwroot`: donde se guardan los archivos estaticos, CSS, archivos HTML, imagenes, iconos y demás.

  - Hay un solo archivo `index.html` ya que Blazor es una `SPA` (Single Page Aplication), en donde un unico archivo `HTML` contiene toda la aplicación y lo que hace este archivo HTML es que su interfaz va mutando de acuerdo a lo que el usuario va seleccionando y de acuerdo a los eventos que van ocurriendo, pero siempre es el mismo archivo HTML.

- Carpeta `Shared`: Contiene los componente compartidos. Son componente que se van a utilizar en otros componentes dentro del sistema, componentes genericos que se quieren reutilizar dentro del sistema en diferentes partes.

- Carptea `Properties`: Contiene la configuración para que se ejecute la aplicación.

- Carpeta `Pages`: Contiene los componentes de la aplicación.

  - Lo más importante de un componentes es su estructura general:
    - El `@page` que contendrá la ruta por la cual se podrá acceder a dicho componente.
    - El `PageTitle` que se refiere al titulo que lleva la página al momento de navegar a ella.
    - `Estructura del HTML` combinado con CSS y C#, cada vez que se vaya a escribir código C# se va inicializar con el `@` para poder empezar a escribir y para que al momento de que se compile la aplicación sepa que esa porción de código se refiere a C#.
    - La sección de `@code` está reservada para todo el código C# que va a tener el componente.
    - En la parte de arriba siempre tener la estructura HTML y en la parte inferior el código de C#.
    - El ejemplo del evento se hace con `@onclick="nombreDelMetodo"`.
    - También dentro de un componente se puede invocar a otro componente compartido pasandole parametros y atributos según lo configurado por ejemplo en el `index.razor` está `<SurveyPrompt Title="How is Blazor working for you?" />`.

## 