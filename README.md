# Curso de Manejo de Datos en C# con LINQ

## Clase 1 - Bienvenida al curso

Se realizará el análisis de cada uno de los operadores y las clausulas que tiene LINQ para la manípulación de colecciones.

LINQ es una de las librerías más populares que hay en .NET, facilita la manipulación de datos en diferentes colecciones, minimizando la cantidad de código que se debe de escribir para poder lograr hacer una tranformación de datos o para poder filtrar los datos de una colección o para compara dos colecciones.

LINQ permite desarrollar un mejor código y seguir las mejores prácticas que hay en .NET, es fundamentas para hacer Querys y desarrollar Backend con Entity Framework (permite que a través de clases conectarnos a una base de datos y manipular las colecciones con código C#).

## Clase 2 - Prerrequisitos

- Conocimiento de C#
- Conocimientos de .NET
- NET SDK 6 0 superior
- Visual Studio Code

## Clase 3 - ¿Qué es LINQ?

- Aparece en el año 2007.
- Language-lntegrated Query (LINQ). (Lenguaje integrado que permite realizar consultas sobre colecciones)
- Query Expression.
- Métodos de extensión.
- System.Linq

**¿Qué no es LINQ?**

- No es un lenguaje de programación.
- No es un componente de SQL.
- No es un componente de base de datos.
- No es una librería de terceros.

**Ejemplo:**

```C#
//LINQ que usa Query Expression.
var unTomate = from t in ArraydeStrings 
                where t == "Tomate"
                    select t;

//LINQ que usa los Métodos de extensión.
ArraydeStrings.Where(t=> t == "Tomate" )
```

