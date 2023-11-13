# Curso de Manejo de Datos en C# con LINQ

Realiza queries fácilmente para manipular información en bases de datos con Language-Integrated Query (LINQ). Añade esta tecnología a Entity-Framework y sigue las mejores prácticas, escribiendo código que sea útil para ti y tu equipo.

- Domina los operadores y cláusulas que tienen LINQ para la manipulación de colecciones
- Minimiza el código para procesar información con la tecnología de LINQ
- Mejora tus habilidades en desarrollo backend para aplicar a tu siguiente puesto

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

Ejemplo Javascript:

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

Ejemplo C#:

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

## Clase 5 - Utilizando LINQ por primera vez

Para esta clase se utilizará un compilador Online [replit.com]( https://replit.com/languages/csharp)

```C#
using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    var frutas = new string[] {"Sandia","Fresa", "Mango", "Mango de azucar", "Mango Tommy"};

  string frutaABuscar = "Mango";
    
    var MangoList = frutas.Where(element=> element.StartsWith(frutaABuscar)).ToList();
    
  MangoList.ForEach(element => Console.WriteLine(element));
    
   //Console.WriteLine ("Hello mundo");
  }
}
```

## Clase 6 - Creando el proyecto base

A nivel de código se crea un nuevo proyecto de consola para poder trabajar las clases de LINQ, luego se debe agregar el archivo de recursos `books.json` que contiene la colección de libros que se utilizará como material de clase.

Se de realizar la configuración en el archivo `cursoDeManejoDeDatosEnCSharpConLINQ.csproj` para agregar el archivo `books.json` como parte de los recursos del contenido del proyecto como tal, de esta manera se puede leer internamente como un archivo más que contiene el proyecto, para esto se crea un las siguiente lineas de código:

```C#
<ItemGroup>
	<Content Include="books.json" />
</ItemGroup>
```

## Clase 7 - Configurando clases

En esta clase se agregará las clases base que se van a necesitar para poder leer el archivo JSON y poder convertirlo a una clase de .NET que podamos manipular utilizando la libreria LINQ.

Se crea la clase `Book.cs` con cada una de las propiedas que contiene el JSON.

Se crea la clase `LinqQueries.cs` donde se estarán escribiendo los querys de LINQ.

## Clase 8 - Importando datos

Ya con el proeycto base configurado y las clases para comunicar C# con el archivo JSON, sigue la importanción de los datos a una colección.

A nivel de código lo que se hizo fue crear el contructor en la clase `LinqQueries.cs`, el constructor se encarga de leer el archivo `books.json` y llevar la información a una variable de la clase `Book` y luego crear otro método que se encargue de retorna el valor de dicha variable.

Luego en la clase `Programs.cs` se realiza la manipulación requerida por medio de las clases para consultar, almacenar e imprimir los datos del JSON.

## Clase 9 - Usando el operador Where

**Clasificación de los operadores**:

- _Operadores básicos_: los que filtran o hacen alguna modificación especifica sobre la colección.

- _Operadores de agregación_: Hacen operaciones sobre todos los datos de la colección.

- _Operadores de agrupamientos_: Permite agrupar los datos de acuerdo a algunos criterios dentro de lacolección.

El operador **Where** recibe una condición o una serie de condiciones y por medio de estas condiciones filtra la colección. Funciona igual a como funciona el where en SQL.

**Reto operador Where 1**:

> Utilizando el operador Where retorna los libros que fueron publicados después del año 200

```C#
//extension method
return librosColletion.Where(p=> p.PublishedDate.Year > 2000);

//query expresion
return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
```

**Reto operador Where 2**:

> Utilizando el operador Where retorna los libros que tengan más de 250 páginas y el título contenga las palabras in Action.

```C#
//extension method
return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

//query expresion
return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action")
        select l;

```

## Clase 10 - Ejercicio para aplicacr el operador Where

Filtra todos los animales que sean de color verde que su nombre inicie con una vocal.

## Clase 11 - Operadores All y Any

_All_: Verifica que una o más condiciones se cumplan en ttodos los elementos de la colección.

_Any_: Verifica que una o más condiciones se cumplan en al menos en uno de los elementos que se encuentran dentro de la colección.

**Reto operador All**:
> Utilizando el operador All verifica que todos los elementos de la colección tenga un valor en el campo Status.

**Reto operador Any**:
> Utilizando el operador Any verifica si alguno de los libros fue publicado en 2005.

## Clase 12 - Operador Contains

Ayuda a verificar si existe o no un elemento en especifico en la colección.

Este operador se puede utilizar tanto para tipo complejos como para tipos primitivos como string o int.

**Reto operador Contains**:

> Utilizando el operador Contains retorna los elementos que pertenezcan a la categoría de Python.

## Clase 13 - Operadores OrderBy y OrderByDescending

Permite realizar ordenamiento en la colección ya sea de forma ascendente o descendente.

**Reto operador OrderBy**:

> Utilizando el operador OrderBy retorna todos los elementos que sean de la categoría de Java ordenados por nombre.

**Reto operador OrderByDescending**:

> Utilizando el operador OrderByDescending retorna los libros que tengan más de 450 páginas, ordenados por número de páginas en forma descendente.

## Clase 14 - Ejercicio operador OrderBy

> Retorna los elementos de la colección animal ordenados por nombre.

## Clase 15 - Operadores Take y Skip

Son utiles para seleccionar una cantidad especifica de elementos en una lista:

_Take_: Definir la cantidad de elementos que queremos tomar, teniendo en cuenta una lista o una colección; nos permite tomar la N cantidad de primeros registros

_Skip_: Nos permite omitir cierta cantidad de registros y luego seleccionar de ahí en adelante todos los demás registros que continuen dentro de la colección.

**Reto operador Take**:

> Utilizando el operador Take selecciona los primeros 3 libros con fecha de publicación más reciente que estén categorizados en Java.

**Reto operador Skip**:

> Utilizando el operador Skip selecciona el tercer y cuarto libro de los que tengan más de 400 páginas.

## Clase 16 - Selección dinámica de datos

El operador **Select** nos permite especificar cuales son las columnas que queremops retornar, esto ayuda mucho en el rendimiento ya que solo se retornan los datos que se requieran.

**Reto operador selección dinámica**:

> Utilizando el operador Select selecciona el título y el número de páginas de los primeros 3 libros de la colección.

## Clase 17 - Operadores LongCount y Count

Los operadores de agregación de LINQ, nos permite realizar un cálculo sobre toda la colección y devolver un dato en especifico.

La diferencia entre los operadores _LongCount_ y _Count_ es que _Count_ soporta 32 Bits y _LongCount_ soporta 64 Bits.

El objetivo de ambos es realizar la cuenta de los elementos dentro de la colección, devuelve cuantos elementos hay.

**Reto operador Count**:

> Utilizando el operador Count, retorna el número de libros que tengan entre 200 y 500 páginas.

## Clase 18 - Operadores Min y Max

Nos permite encontrar un valor máximo y un valor mínimo.

**Reto operador Min**:

> Utilizando el operador Min, retorna la menor fecha de publicaciön de la lista de libros.

**Reto operador Max**:

> Utilizando el operador Max, retorna la cantidad de páginas del libro con mayor número de páginas en la colección.

## Clase 19 - Operadores MinBy y MaxBy

Nos permite encontrar un valor máximo o mínimo de la colección pero en vez de retornar el dato, retorna el objeto completo con todos sus atributos.

**Reto operador MinBy**:

> Retorna el libro que tenga la menor cantidad de páginas mayor a 0.

**Reto operador MaxBy**:

> Retorna el libro con la fecha de publicación más reciente.

## Clase 20 - Operadores Sum y Aggregate

**Reto opeador Sum**:

> Retorna la suma de la cantidad de páginas, de todos los libros que tengan entre 0 y 500.

El operador _Aggregate_ lo que hace es ir concatenando o va sumando, creando un total de manera personalizada y retornar ese valor al final.

Necesita una semilla del valor que se vaya a utilizar (puede ser un entero, double, string) y una variable que va a ir tomando el valor de cada uno de los libros de la colección.

**Reto operador Aggregate**:

> Retorna el título de los libros que tienen fecha de publicación posterior a 2015.

## Clase 21 - Operador Average

Permite sacar un promedio de algúna propiedad númerica que tengamos dentro de la colección.

**Reto operador Average**:

Utilizando el operador Average, retorna el promedio de caracteres que tienen los títulos de la colección.

## Clase 22 - Cláusula GroupBy

Operador de agrupamiento.

**Reto operador GroupBy**:

> Retorna todos los libros que fueron publicados a partir del 2000, agrupados por año.

A nivel de código se implementó un método nuevo llamado `ImprimirGroupo` esto se debe a que el operador de agrupamiento `GroupBy` además del `IEnumerable` también retorna un `IGrouping` por lo cuál la manipulación de los datos para imprimirlos cambia un poco en la lógica.

## Clase 23 - Ejercicio cláusula GroupBy

> Retorna los datos de la colleción Animales agrupada por color.

## Clase 24 - Cláusula Lookup

Permite realizar agrupamiento pero en forma de diccionario, de está manera se puede consultar la lista de elementos de una manera más simple.

**Reto operador Lookup**:

> Retorna un diccionario usando Lookup que permita consultar los libros de acuerdo a la letra con la que inicia el título del libro.

## Clase 25 - Cláusula Join

Permité interceptar 2 colecciones y devolver los elementos que se encuentran en ambas colecciones.

**Reto operador Join**:

> Obtén una colección que tenga todos los libros con más de 500 páginas y otra que contenga los libros publicados después del 2005.
Utilizando la cláusula Join, retorna los libros que estén en ambas colecciones.

