# Curso de Fundamentos de .NET

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

![Imágen del Funcionamiento del CLR](images\Funcionamiento_del_CLR.png)

**CoreCLR para .NET Core**:

Es una nueva versión del CLR que se creó con .NET Core.

