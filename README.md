# Curso de Unit Testing con C# y .NET

Este curso está diseñado para proporcionarte una comprensión completa de las pruebas unitarias en el entorno de desarrollo de C# y .NET. A lo largo del curso, aprenderás los fundamentos de las pruebas unitarias, cómo escribir y ejecutar pruebas, y cómo utilizar frameworks de pruebas populares como NUnit y xUnit.

## Clase 1 - Conoce una prueba unitaria de concatenación de strings en C\#

Pruebas unitarias: pequeñas piezas de código que van a ayudar a probar la lógica de las aplicaciones.

El proyecto del curso se basa en una serie de operaciones para manipular diferentes Strings.

Para convertir una función en prueba lo que se tiene que hacer es agregar el atributo `[Fact]`.

## Clase 2 - Prerequisitos

- Conocimientos de C# y .NET
- POO en C#
- .NET 7 0 superior
- Visual Studio Code o Visual Studio

## Clase 3 - ¿Qué son pruebas unitarias?

**TDD**(Test-Driven Development): Metodología de trabajo o estilo de programación. Lo que dice TDD es se deben crear todas las pruebas al inicio del proyecto, esas prueba van a fallar ya que aún no existe la implementación del código.

Una vez implementado el código deben de pasar todas las pruebas, luego se debe de estar realizando un refactor constantemente, ya que se puede estar agregando lógica que antes no se habia contemplado o nuevos funcionamientos solicitados.

**Pruebas unitarias:**

- Pruebas sobre una unidad de código como una propiedad, función o método.
- Automatizables.
- Reutilizables.
- Independientes.

En resumen se puede decir que las pruebas unitarias son: **Piezas de código que pruebas otras piezas de código**

**Importancia:**

- Nos ayudan a verificar de manera rápida la lógica de negocio de nuestro código.
- Detectan cambios que afectan la funcionalidad de manera rápida.
- Se implementan del lado de desarrollo.
- Son fáciles de implementar.

Enlace:

[Free Ebook - Unit Testing Succinctly](https://www.syncfusion.com/succinctly-free-ebooks/unittesting)

## Clase 4 - Librerías de pruebas en .NET

**MSTest**:

- Microsoft Test.
- Gran soporte por el equipo de Microsoft.
- Excelente integración con Visual Studio.
- Alta complejidad para algunos escenarios.

**NUnit**:

- JUnit para .NET.
- Opensource con gran soporte.
- Muy fácil de usar.

**xUnit**: (Librería a usar en el curso)

- Creada por la comunidad.
- Open source con gran soporte.
- Simplifica todo el proceso de creación de pruebas.
- Una de las más populares para nuevos y modernos proyectos con .NET.


Enlaces:

- [NUnit.org](https://nunit.org/)
- [Home > xUnit.net](https://xunit.net/)
- [Unit testing C# with MSTest and .NET - .NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)

![Ejemplo de XUnit](images/ejemplo_xunit.png)

Solo se necesita el atributo `[Fact]` para que cualquier método se convierta en una prueba unitaria, se utiliza el `Assert.` que ayuda a verificar el resultado de la prueba y corressponda con lo que se necesita.

## Clase 5 - Herramientas y código base

Código base se encuentra en GitHub en la rama Master o rama 0-codigobase:

[GitHub - platzi/curso-unit-testing-csharp](https://github.com/platzi/curso-unit-testing-csharp)

El proyecto representa lo que sería una librería en un proyecto real que tiene diferentes funciones para manipular cadena de caracteres.

