﻿#region Clase 8 - Importando datos
//using cursoDeManejoDeDatosEnCSharpConLINQ;

//Console.WriteLine("Curso de Manejo de Datos en C# con LINQ");
//Console.WriteLine("***************************************************************************************************************");

//LinqQueries queries = new LinqQueries();

//ImprimirValores(queries.TodaLaColeccion());

//void ImprimirValores(IEnumerable<Book> listaDeLibros)
//{
//    string formatoTexto = "\t{0,-60} {1,15} {2, 15}";

//    Console.WriteLine($"{formatoTexto}\n", "Titulo", "N. Paginas", "Fecha publicacion");

//    foreach (var item in listaDeLibros)
//    {
//        Console.WriteLine($"{formatoTexto}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
//    }
//}
#endregion

#region Clase 9 - Usando el operador Where
//using cursoDeManejoDeDatosEnCSharpConLINQ;

//Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine("Curso de Manejo de Datos en C# con LINQ");
//Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine();

//LinqQueries queries = new LinqQueries();

////Toda la colección
//Console.WriteLine("Toda la colección");
//ImprimirValores(queries.TodaLaColeccion());
//Console.WriteLine("*****************************");

////Libros después del 2000
//Console.WriteLine("Libros después del 2000");
//ImprimirValores(queries.LibrosDespuesDel2000());
//Console.WriteLine("*****************************");

////Libros con más 250 páginas y título contenga "in Action"
//Console.WriteLine("Libros con más 250 páginas y título contenga \"in Action\"");
//ImprimirValores(queries.LibrosMasDeCantidadPagsYPalabraClave(250,"in Action"));
//Console.WriteLine("*****************************");

//void ImprimirValores(IEnumerable<Book> listaDeLibros)
//{
//    string formatoTexto = "\t{0,-60} {1,15} {2, 15}";

//    Console.WriteLine($"{formatoTexto}\n", "Titulo", "N. Paginas", "Fecha publicacion");

//    foreach (var item in listaDeLibros)
//    {
//        Console.WriteLine($"{formatoTexto}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
//    }
//}
#endregion

#region Clase 10 - Ejercicio para aplicar el operador Where
//using System;
//using System.Collections.Generic;
//using System.Linq;

//List<Animal> animales = new List<Animal>();
//animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
//animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
//animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
//animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
//animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
//animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
//animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
//animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
//animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

//// Escribe tu código aquí
//// filtra todos los animales que sean de color verde que su nombre inicie con una vocal
//IEnumerable<Animal> animalesFiltrados = animales.Where(p => p.Color == "Verde" && ComienzaConVocal(p.Nombre));

//foreach (Animal animal in animalesFiltrados)
//{
//    Console.WriteLine(animal.Nombre);
//}


///// Método auxiliar para verificar si una cadena comienza con una vocal
//static bool ComienzaConVocal(string palabra)
//{
//    if (string.IsNullOrEmpty(palabra))
//    {
//        return false;
//    }

//    char primeraLetra = palabra[0];
//    return "aeiouAEIOU".IndexOf(primeraLetra) != -1;
//}

//public class Animal
//{
//    public string Nombre { get; set; }
//    public string Color { get; set; }
//}
#endregion

#region Clase 11 - Operadores All y Any
//using cursoDeManejoDeDatosEnCSharpConLINQ;

//Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine("Curso de Manejo de Datos en C# con LINQ");
//Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine();

//LinqQueries queries = new LinqQueries();

////Toda la colección
//Console.WriteLine("Toda la colección");
//ImprimirValores(queries.TodaLaColeccion());
//Console.WriteLine("*****************************");

//////Libros después del 2000
////Console.WriteLine("Libros después del 2000");
////ImprimirValores(queries.LibrosDespuesDel2000());
////Console.WriteLine("*****************************");

//////Libros con más 250 páginas y título contenga "in Action"
////Console.WriteLine("Libros con más 250 páginas y título contenga \"in Action\"");
////ImprimirValores(queries.LibrosMasDeCantidadPagsYPalabraClave(250, "in Action"));
////Console.WriteLine("*****************************");

////Todos los libros tienen status
//Console.WriteLine("Verificar que todos los elementos tengan un valor en el campos Status");
//Console.WriteLine($"Todos los libros  tienen status? - {queries.TodosLosLibrosTienenStatus()}");
//Console.WriteLine("*****************************");

////Algún libro fue publicado en 2005
//Console.WriteLine("Algún libro fue publicado en 2005");
//Console.WriteLine($"Algún libro fue publicado en 2005? - {queries.SiAlgunLibroPublicadoEn2005()}");
//Console.WriteLine("*****************************");

//void ImprimirValores(IEnumerable<Book> listaDeLibros)
//{
//    string formatoTexto = "\t{0,-60} {1,15} {2, 15}";

//    Console.WriteLine($"{formatoTexto}\n", "Titulo", "N. Paginas", "Fecha publicacion");

//    foreach (var item in listaDeLibros)
//    {
//        Console.WriteLine($"{formatoTexto}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
//    }
//}
#endregion

#region Clase 12 - Operador Contains
//using cursoDeManejoDeDatosEnCSharpConLINQ;

//Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine("Curso de Manejo de Datos en C# con LINQ");
//Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine();

//LinqQueries queries = new LinqQueries();

////Toda la colección
//Console.WriteLine("Toda la colección");
//ImprimirValores(queries.TodaLaColeccion());
//Console.WriteLine("*****************************");

//////Libros después del 2000
////Console.WriteLine("Libros después del 2000");
////ImprimirValores(queries.LibrosDespuesDel2000());
////Console.WriteLine("*****************************");

//////Libros con más 250 páginas y título contenga "in Action"
////Console.WriteLine("Libros con más 250 páginas y título contenga \"in Action\"");
////ImprimirValores(queries.LibrosMasDeCantidadPagsYPalabraClave(250, "in Action"));
////Console.WriteLine("*****************************");

//////Todos los libros tienen status
////Console.WriteLine("Verificar que todos los elementos tengan un valor en el campos Status");
////Console.WriteLine($"Todos los libros  tienen status? - {queries.TodosLosLibrosTienenStatus()}");
////Console.WriteLine("*****************************");

//////Algún libro fue publicado en 2005
////Console.WriteLine("Algún libro fue publicado en 2005");
////Console.WriteLine($"Algún libro fue publicado en 2005? - {queries.SiAlgunLibroPublicadoEn2005()}");
////Console.WriteLine("*****************************");

////Libros de python
//Console.WriteLine("Libros de python");
//ImprimirValores(queries.LibrosDePython());
//Console.WriteLine("*****************************");

//void ImprimirValores(IEnumerable<Book> listaDeLibros)
//{
//    string formatoTexto = "\t{0,-60} {1,15} {2, 15}";

//    Console.WriteLine($"{formatoTexto}\n", "Titulo", "N. Paginas", "Fecha publicacion");

//    foreach (var item in listaDeLibros)
//    {
//        Console.WriteLine($"{formatoTexto}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
//    }
//}
#endregion

#region Clase 13 - Operadores OrderBy y OrderByDescending
//using cursoDeManejoDeDatosEnCSharpConLINQ;

//Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine("Curso de Manejo de Datos en C# con LINQ");
//Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
//Console.WriteLine();

//LinqQueries queries = new LinqQueries();

////Toda la colección
//Console.WriteLine("Toda la colección");
//ImprimirValores(queries.TodaLaColeccion());
//Console.WriteLine("*****************************");

//////Libros después del 2000
////Console.WriteLine("Libros después del 2000");
////ImprimirValores(queries.LibrosDespuesDel2000());
////Console.WriteLine("*****************************");

//////Libros con más 250 páginas y título contenga "in Action"
////Console.WriteLine("Libros con más 250 páginas y título contenga \"in Action\"");
////ImprimirValores(queries.LibrosMasDeCantidadPagsYPalabraClave(250, "in Action"));
////Console.WriteLine("*****************************");

//////Todos los libros tienen status
////Console.WriteLine("Verificar que todos los elementos tengan un valor en el campos Status");
////Console.WriteLine($"Todos los libros  tienen status? - {queries.TodosLosLibrosTienenStatus()}");
////Console.WriteLine("*****************************");

//////Algún libro fue publicado en 2005
////Console.WriteLine("Algún libro fue publicado en 2005");
////Console.WriteLine($"Algún libro fue publicado en 2005? - {queries.SiAlgunLibroPublicadoEn2005()}");
////Console.WriteLine("*****************************");

//////Libros de python
////Console.WriteLine("Libros de python");
////ImprimirValores(queries.LibrosDePython());
////Console.WriteLine("*****************************");

////Libros de Java ordenados por nombre
//Console.WriteLine("Libros de Java ordenados por nombre");
//ImprimirValores(queries.LibrosDeJavaPorNombreAscendente());
//Console.WriteLine("*****************************");


//// Libros de más de 450 páginas ordenados por cantidad de páginas descendente
//Console.WriteLine("Libros de más de 450 páginas ordenados por cantidad de páginas descendente");
//ImprimirValores(queries.LibrosMasDe450PagsOrdenadosPorNumPagDescendente());
//Console.WriteLine("*****************************");


//void ImprimirValores(IEnumerable<Book> listaDeLibros)
//{
//    string formatoTexto = "\t{0,-60} {1,15} {2, 15}";

//    Console.WriteLine($"{formatoTexto}\n", "Titulo", "N. Paginas", "Fecha publicacion");

//    foreach (var item in listaDeLibros)
//    {
//        Console.WriteLine($"{formatoTexto}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
//    }
//}
#endregion

#region Clase 14 - Ejercicio operador OrderBy
using System;
using System.Collections.Generic;
using System.Linq;

List<Animal> animales = new List<Animal>();
animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

// Escribe tu código aquí
// Retorna los elementos de la colleción animal ordenados por nombre
IEnumerable<Animal> animalesOrdenados = animales.OrderBy(p => p.Nombre);

foreach(Animal animal in animalesOrdenados)
{
    Console.WriteLine(animal.Nombre);
}

public class Animal
{
    public string Nombre { get; set; }
    public string Color { get; set; }
}

#endregion