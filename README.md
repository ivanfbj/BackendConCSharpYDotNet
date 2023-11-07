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

## Clase 4 - Programación declarativa vs. imperativa

Son 2 estilos programación usados en el desarrollo de software, ambos estilos son altamente usados.

La programación imperativa se centra en los pasos detallados para lograr un resultado, mientras que la programación declarativa se centra en definir el resultado deseado sin preocuparse por los detalles de implementación. Cada enfoque tiene sus ventajas y desventajas, y a menudo se utilizan en combinación para abordar diferentes aspectos de un problema de programación.

**_Comparativa_**:

|Programación declarativa | Programación imperativa |
|-------------------------|-------------------------|
|Paradigma de la programación.|Paradigma de la programación.|
|Instrucciones donde especifico lo que quiero y no como lo quiero.|Secuencia paso a paso de instrucciones.|
|Contraposición a la programación imperativa.|Contraposición a la programación declarativa.|
|Fiable y simple.|Código más extenso pero fácil de interpretar.|

```Javascript
// Declarativo
const array1 = [1, 2, 3, 4, 5];
array1.forEach(element => console.log(element));

// Imperativo
const array1 = [1, 2, 3, 4, 5];
for (let i = 0; i < array1.length; i++){
    console.log(array1[i]);
}
```

```C#
// Declarativo
var listOfNumbers = new int[] {1,2,3,4,5};
var iteml = listOfNumbers.FirstOrDefault(p=> p==l);
Console.WriteLine(item1);

// Imperativo
var listOfNumbers = new int[] {1,2,3,4,5};
for (int i = 0; i < listOfNumbers.Length; i++){
    if(listOfNumbers[i] == 1)
        Console.WriteLine(listOfNumbers[i] );
}
```

