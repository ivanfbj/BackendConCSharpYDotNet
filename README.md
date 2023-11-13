# Curso de Fundamentos de .NET

Aprende los fundamentos para empezar a trabajar como un profesional usando .NET. Identifica los diferentes componentes que lo integran y empieza a familiarizarte con este framework. Aprende a instalar .NET junto con tu profesor Miguel Teheran.

- Aprender las bases de .NET.
- Identificar las diferencias entre .NET, .NET Core y .NET Framework.
- Explorar la estructura de un proyecto en .NET.
- Instalar paquetes externos con NuGet.

## Clase 1 - Todo lo que aprenderás sobre .NET

- Conocimientos base de .NET
- Análisis de los componentes para el funcionamientos de .NET
- Demos para el acercamiento a esta tecnólogia.

## Clase 2 - Prerrequisitos

- Conceptos generales de programación.
- Conocimientos generales de C#.
- Visual Studio Code.

## Clase 3 - ¿Qué es .NET?

Plataforma de desarrollo de aplicaciones creada por Microsoft.

Cuando se habla de .NET es un conjunto de librerias que permiten desarrollar aplicaciones para diferentes plataformas.

.NET fue creada por Microsoft para ofrecerle a los desarrolladores la oportunidad de crear fácilmente aplicaciones de todo tipo utilizando un solo SDK (kit de desarrollo de software), unico conjunto de librerias base para todas las posibles plataformas y tipos de posibles aplicaciones que hay en el mercado.

**Datos sobre .NET**:

- Creada en 2016.
- De código abierto y gratuito.
- Multiplataforma.
- Programado en y C++.
- Orientado a alto rendimiento y la nube.

___
Enlaces:

[.NET documentation | Microsoft Docs](https://docs.microsoft.com/dotnet/)
[GitHub - dotnet/core: Home repository for .NET Core](https://github.com/dotnet/core)

## Clase 4 - .NET Framework vs .NET Core

.NET Framework fue la primera versión que se liberó de .NET y .NET Core es la versión moderna, es la evolución como tal de este Framework.

**.NET Framework**:

- Primera versión del framework en 2001.
- Compatible solo Windows.
- Plataforma de ejecución intermedia.
- Compatible con VB .NET, F#, Visual C++.
- Diseñado para apps corporativas con arquitectura tradicional.
- Soporte extendido por al menos 10 años.

**Tabla de diferencias**:

|.NET Framework | .NET Core |
|---------------|-----------|
|Compatible con Windows.|Multiplataforma (Windows,Linux, MacOS).|
|C#, Visual Basic .NET, F#, Visual C++.|C#, F#, Visual Basic.|
|Orientado a aplicaciones monolíticas y corporativas.|Orientado al alto rendimiento y arquitecturas orientadas a la nube.|
|Dependencia de Visual Studio.|Sin dependencias de IDE o editor de texto.|

**.NET Core = .NET**:

Microsoft quiere evitar el uso del nombre como tal de **.NET Core**, sino que en su estandar, documentación entre otros, el objetivo es que se mencione solamente como **.NET**

**En resumen**:

- **.NET**:
  - Es la abreviatura de .NET Core, versión actual de .NET.

- **.NET Core**:
  - Es la evolución .NET y sucesor de .NET Framework.

- **.NET Framework**:
  - Primera versión del framework con soporte extendido.

## Clase 5 - Ventajas y usos de .NET

**Podemos usar .NET para crear:**

- Aplicaciones de consola y librerías.
- Aplicaciones para Windows usando WinForms, WPF, UWP, WinUI 3.
- Aplicaciones web y web APIs usando ASP .NET.
- Aplicaciones móviles usando Xamarin y NET MAUI.
- Aplicaciones Web usando Web assembly con Blazor.

**Ventajas:**

- Multiplataforma.
- Compatible con múltiples lenguajes de programación.
- Muchas herramientas y librerías gratuitas.
- Evolución y mejoras.
- Apoyo de la comunidad y documentación.
- Soporte continuo.
- Integración con servicios Microsoft.
- Retrocompatibilidad.

## Clase 6 - Línea de tiempo de .NET y C\#

- **Primera línea de tiempo**:

  - 2002 - **.Net Framework 1.0**
  - 2005 - **.Net Framework 2.0**
  - 2010 - **.Net Framework 4.0**
  - 2012 - **.Net Framework 4.5**
  - 2016 - **.Net Framework 4.6.1** - **.NET Core 1.0**

- **Línea de tiempo .NET**:
  - 2016 - **.NET Core 1.0**
  - 2017 - **.NET Core 2.0 (LTS)**
  - 2019 - **.NET Core 3.0 (LTS)**
  - 2020 - **.NET Core 5**
  - 2021 - **.NET 6 (LTS)**
  - 2022 - **.NET 7**
  - 2023 - **.NET 8 (LTS)**
  - 2024 - **.NET 9**

## Clase 7 - Common Language Runtime (CLR)

Es la base con la que se ejecutan las aplicaciones de .NET, ya sea en la máquina local o aplicaciones en producción.

**Características**:

- Transforma de Common Intermediate Language (CIL) o MSIL a Código nativo.
- Compilador en tiempo de ejecución.
- Agiliza la ejecución del código compilado.

Todos los lenguajes que trabajan con .NET son lenguajes compilados, así que son lenguajes que pasan de una sintaxis de alto nivel a una sintaxis de bajos nivel. Luego de que se realiza está transformación, entra un componente a ejecutar ese lenguaje de bajo nivel en este caso el **CLR**.

El CLR se utiliza en tiempo de ejecución, mientras se este programando o compilando el CLR no hace nada.

EL CLR ayuda a agilizar la ejecuión del código compilado, esto permite que .NET sea una plataforma rápida con gran rendimiento.

![Imágen del Funcionamiento del CLR](images/Funcionamiento_del_CLR.png)

**CoreCLR para .NET Core**:

Es una nueva versión del CLR que se creó con .NET Core.

## Clase 8 - Compilador Roslyn

Los lenguajes deben de pasar por un proceso de transformación y debe de haber un agente que se encargue de hacer dicha transformación en ese caso el compilador Roslyn.

- Conocido como .NET Compiler Platform.
- Soporta C# y Visual Basic.
- Analiza estilo y calidad de código usando niveles de severidad.
- Rápido y ágil.

Fue desarrollado junto con la nueva versión de .NET para agilizar el proceso de compilación, es decir el proceso de transformación que tienen los lenguajes de programación de alto nivel a un lenguaje de bajo nivel que pueda ser ejecutado por el CLR.

Roslyn soporta 2 lenguajes de programación que son C# y Visual Basic, ambos lenguajes son análizados y convertido a este lenguaje de bajo nivel por el mismo compilador.

Roslyn permite análizar el estilo y la calidad de código. Ha venido mejorando para mejorar la expeiencia de desarrollo con .NET

Ejemplo:
Roslyn genera las advertencia de las directiva que se están utilizando y muestra sugerencias del código que acaba de analizar.

![Ejemplo de Roslyn](images/ejmplo_Roslyn.png)

Roslyn viene integrado por defecto en Visual Studio y al dotnet CLI.

## Clase 9 - Common Language Specification

Es una regla de metricas que deben seguir los lenguajes para que puedan ser compilados todos a un mismo lenguaje de bajo nivel para luego ser ejecutados y leídos por .NET.

> Permite compilar los lenguajes de alto nivel en un lenguaje común Common Intermediate Language (CIL)

El CLS es una serie de reglas que deben seguir todos los lenguajes para poder ser compilados a un único lenguaje que sería el Common Intermediate Language (CIL), en caso de .NET el **CLS** traduce a un código conocido como "Assembly" y este código es el mismo para cualquer lenguaje de programación (C#, F#, Visual Basic).

**Características**:

- Diseñado para lenguajes compilados.
- Soporta C#, Visual Basic, F#.
- Permite comunicación entre componentes de diferentes de lenguaje.

**Ejemplo de CLS:**

![Ejemplo de CLS](images/ejemplo_de_CLS.png)

## Clase 10 - Common Type System

Define los diferentes grupos de tipos de datos que debe tener un lenguaje de programación que sea compatible con .NET.

**Características**:

- Define los tipos generales que se usan dentro del lenguaje.
- Provee la librería base para los tipos primitivos (byte, char, int).
- Provee un modelo de tipos orientado a objetos.

**Categorias del CTS**:

- Clases
- Estructuras
- Enumeraciones
- Interfaces
- Delegados

## Clase 11 - Instalación del SDK

[Download .NET (Linux, macOS, and Windows)](https://dotnet.microsoft.com/en-us/download)

Comando para verificar la versión instalada:

```Bash
dotnet --version
```

## Clase 12 - IDEs para trabajar con .NET

IDE: Integrated Development Environment, entorno de desarrollo integrado.

- **Visual Studio**: es la herramientas más completa para trabajar con .NET.

  - **Características de VS**: **

    - Integrado a .NET Framework y .NET Core.
    - Soporta todos los tipos de proyectos de .NET.
    - Soporta extensiones para ampliar funciones.
    - Nueva versión cada 3 años.
    - Plataforma Windows.
    - Version Community, Profesional, Enterprise.

- **Rider de JetBrains**:
  - **Características de Rider**
    - Más ligero que Visual Studio.
    - Herramientas avanzadas de autocompletado.
    - Multiplataforma.
    - Contiene las herramientas de Resharper.
    - Licenciado.

- **Visual Studio Code**
  - **Características de VS Code**
    - Multiplataforma.
    - Ligero.
    - Muchas extensiones para potencializar.
    - Gratuito y de código abierto.
    - Soporte la mayoría de lenguajes de
    - programación.

## Clase 13 - dotnet CLI

**Command-line interface**: Es una de las herramientas más importantes que tiene .NET. Con esta herramientas se podrá compilar, ejecutar y publicar los proyectos desarrollados en .NET.

Se divide en 2 grupos de comandos:

**Generales**:

- Creación de un proyecto.
- Creación de archivos de configuración.
- Invocación de tools.

**Sobre un proyecto**:

- Restaurar.
- Compilar.
- Ejecutar.
- Limpiar.
- Ejecutar pruebas.

`dotnet --help`: Comando que brinda toda la ayuda de como funciona el CLI, lista los comando y tiene una breve descripción de para que funciona cada uno.
![dotnet -help](images/dotnet_help.png)

`dotnet --version`: Revisar la versión de .NET que está instalada.

`dotnet --info`: permite revisar las diferentes versiones de los SKD de .NET que se tienen instalada en el equipo.

`dotnet new`: nos va a dar las opciones que se tiene para crear un nuevo proyecto en .NET.

## Clase 14 - Primera App con dotnet CLI

`dotnet new console`: Para crear un proyecto con la plantilla de tipo consola, se crea un proyecto de consola.

`dotnet new list`: Muestra los nombre de todas las plantillas disponibles para crear un nuevo proyecto en .NET.

`dotnet run`: comando para ejecutar el proyecto luego de haber sido creado.

## Clase 15 - Estructura de un proyecto .NET

**Estructura de un proyecto de consola**:

El archivo `Program.cs` tiene el código que se ejecuta al momento de correr el proyecto con el comando `dotnet run`.

El archivo `cursoDeFundamentosDeDotNet_console.csproj` contiene todas las caracteristicas que tiene el proyecto en general, es un archivo de configuración. Es un archivo en formato XML, una de sus propiedad hace referencia al SDK que utiliza dependiendo del proyecto.

**Estructura de un proyecto web api**:

El archivo `cursoDeFundamentosDeDotNet_webapi.csproj` tiene un SDK diferente al proyecto de consola, adicionalmente agrega las referencias a unas librerias por defecto.

El archivo `Program.cs` contiene mayor cantidad de código ya que tiene más información que permite que la API se pueda ejecutar sin problema.

## Clase 16 - Compilación y ejecución

Crear mini proyecto para entender el proceso de compilación y ejecución de proyecto en .NET.

`dotnet build` es el comando que nos permite compilar el código para verificar que el código este compilando sin errores, tanto a nivel de código como de las dependencias que se esten utilizando.

`dotnet restore` es el comando que nos permite restaurar las dependencias o librerías que están dentro del proyecto.

`dotnet watch run` es el comando que nos permite ejecutar el proyecto y estar revisando los cambios realizados en tiempo real.

## Clase 17 - Archivos de compilación

Dentro del proceso de compilación tenemos dos carpetas relacionadas

`obj` : Tiene los archivos que se generan en la compilación de manera temporal, para despues entregar el resultado final que se guardará en la carpeta bin.

`bin` : Contiene el archivo compilado del proyecto .dll y más

- Dentro de esta carpeta se encuentra el archivo .exe, que es el ejecutable de la aplicación que se genera.

Para limpiar la compilación hecha, podemos usar el comando `dotnet clean` para eliminar todo el contenido de la carpeta `bin`.

**Existen dos modos de compilación en .NET**:

- **modo debug**

  - Prepara la aplicación para el uso en un ámbito de pruebas, suele ser un poco más pesado que el modo de compilado release. Se recomienda no usar este compilado en modo producción, ya que se puede exponer información que solo nos interesa que se muestre cuando estamos probando y no así cuando nuestros clientes lo ejecuten.
ㅤ
- **modo release**

  - Prepara la aplicación para que esté lista en producción, tenga un mejor rendimiento, además de que sea mucho más liviano. Elimina todos los archivos que no se necesitan en producción.

  - `dotnet build --configuration release` es el comando que nos permite generar el compilado en **modo release**.

## Clase 18 - Archivo Global JSON

Es un archiv que nos permite administrar las versiones de los SDK con los que trabajamos en .NET.

El archivo global JSON se puede crear manualmente o por medio de un comando del CLI: `dotnet new globaljson`

Al ejecutar el comando se crea el archivo `global.json` que por defecto trae la configuración de la versión del SDK, el objetivo es poder cambiar la versión según se requiera para que el proyecto utilice una versión antigua.

Dentro de la propiedad sdk, existe otra propiedad llamada `allowPrerelease`, esta propiedad nos permite colocarla en `false` o `true` y de esta manera habilitar o deshabilitar el uso de release que no son oficiales dentro del excosistema de .NET, generalmente son releases que estan en modo de prueba, preview o beta, de esta manera se puede forzar a que por ningún motivo se utilice un SDK que este en prueba.

## Clase 19 - Cómo encontrar paquetes para .NET usando NuGet

NuGet es el gestor de paquetes de .NET, con NuGet se pueden utilizar diferentes librerías que se encuentran publicadas y compartidas por otros desarrolladores y en general por la comunidad Open Source.

Nuget.org es el sitio oficial y público donde podemos utilizar diferentes librerías que se encuentran completamente abiertas para toda la comunidad.

Sin embargo también se puede crear un servidor propio de NuGet para tener librerías que sean cerradas o privadas que solo sean consumidas por los proyectos de la organización.

## Clase 20 - Descargando un paquete con Nuget

Se requiere un paquete NuGet que nos permita pasar un dato númerico a texto.

La librería [Humanizer](https://www.nuget.org/packages/Humanizer) nos permitirá manipuilar diferentes tipos de datos que tiene .NET y convertirlos en texto o palabras.

Entre las diferentes formas que hay para implementar o descargar el paquete se utilizará la forma de `.NET CLI`

```Bash
dotnet add package Humanizer --version 2.14.1
```

Con este comando se agrega el paquete al proyecto al revisar el archivo `cursoDeFundamentosDeDotNet_console.csproj` se ha agregado la referencia al paquete.

```XML
  <ItemGroup>
    <PackageReference Include="Humanizer" Version="2.14.1" />
  </ItemGroup>
```

A nivel de código en el archivo `Program.cs` se hace la importanción del paquete `Humanizer` y ya nos permite utilizar el método en las variables de tipo int.
