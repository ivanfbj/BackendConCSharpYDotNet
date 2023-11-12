#region Clase 8 - Importando datos
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
//// Retorna los elementos de la colleción animal ordenados por nombre
//foreach (Animal animal in animales.OrderBy(p => p.Nombre))
//{
//    Console.WriteLine(animal.Nombre);
//}

//public class Animal
//{
//    public string Nombre { get; set; }
//    public string Color { get; set; }
//}
#endregion

#region Clase 15 - Operadores Take y Skip
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

//// Los 3 libros de Java publicados recientemente
//Console.WriteLine("Los 3 libros de Java publicados recientemente");
//ImprimirValores(queries.TresPrimerosLibrosJavaOrdenadosPorFecha());
//Console.WriteLine("*****************************");

//// Tercer y cuarto libro con más de 400 páginas
//Console.WriteLine("Tercer y cuarto libro con más de 400 páginas");
//ImprimirValores(queries.TerceryCuartoLibroDeMas400Pags());
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

#region Clase 16 - Selección dinámica de datos
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

//// Tres primeros libros filtrados con Select
//Console.WriteLine("Tres primeros libros filtrados con Select");
//ImprimirValores(queries.TresPrimerosLibrosDeLaColeccion());
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

#region Clase 17 - Operadores LongCount y Count
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

//// Cantidad de libros que tienen entre 200 y 500 páginas
//Console.WriteLine("Cantidad de libros que tienen entre 200 y 500 páginas\n");
//Console.WriteLine($"Cantidad de libros entre 200 y 500 páginas: {queries.CantidadDeLibrosEntre200y500Pags()}");
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

#region Clase 18 - Operadores Min y Max
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

//// Fecha de publicación menor de todos los libros
//Console.WriteLine("Fecha de publicación menor de todos los libros\n");
//Console.WriteLine($"Fecha de publicación menor: {queries.FechaDePublicacionMenor().ToShortDateString()}");
//Console.WriteLine("*****************************");

//// Número de páginas del libro con mayor Número de páginas
//Console.WriteLine("Número de páginas del libro con mayor Número de páginas\n");
//Console.WriteLine($"El libro con mayor número de páginas tiene: {queries.NumeroDePagsLibroMayor()} páginas");
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

#region Clase 19 - Operadores MinBy y MaxBy
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

//// Libro con menor número de páginas
//Console.WriteLine("Libro con menor número de páginas");
//Book libroMenorPag = queries.LibroConMenorNumeroDePaginas();
//Console.WriteLine($"{libroMenorPag.Title} - {libroMenorPag.PageCount}");
//Console.WriteLine("*****************************");

//// Libro con fecha de publicación más reciente
//Console.WriteLine("Libro con fecha de publicación más reciente");
//Book libroFechaPubReciente = queries.LibroConFechaPublicacionMasReciente();
//Console.WriteLine($"{libroFechaPubReciente.Title} - {libroFechaPubReciente.PublishedDate.ToShortDateString()}");
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

#region Clase 20 - Operadores Sum y Aggregate
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

////Suma de paginas de libros entre 0 y 500
//Console.WriteLine("Suma de paginas de libros entre 0 y 500");
//Console.WriteLine($"Suma total de páginas {queries.SumaDeTodasLasPaginasLibrosEntre0y500()}");
//Console.WriteLine("*****************************");

//// Libros publicado despues del 2015
//Console.WriteLine("Libros publicado despues del 2015");
//Console.WriteLine($"{queries.TitulosLibrosDespuesDel2015Concatenados()}");
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

#region Clase 21 - Operador Average
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

////El promedio de caracters de los titulos de los libros
//Console.WriteLine("El promedio de caracters de los titulos de los libros");
//Console.WriteLine($"Promedio caracteres de los titulos: {queries.PromedioCaracteresTitulo()}");
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

#region Clase 22 - Cláusula GroupBy
using cursoDeManejoDeDatosEnCSharpConLINQ;

Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Curso de Manejo de Datos en C# con LINQ");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
Console.WriteLine();

LinqQueries queries = new LinqQueries();

//Toda la colección
Console.WriteLine("Toda la colección");
ImprimirValores(queries.TodaLaColeccion());
Console.WriteLine("*****************************");

// Libros publicados despues a partir del 2000 agrupados por año.
Console.WriteLine("Libros publicados despues a partir del 2000 agrupados por año.");
ImprimirGroupo(queries.LibrosDespuesDel2000AgrupadosPorAno());

Console.WriteLine("*****************************");

void ImprimirValores(IEnumerable<Book> listaDeLibros)
{
    string formatoTexto = "\t{0,-60} {1,15} {2, 15}";

    Console.WriteLine($"{formatoTexto}\n", "Titulo", "N. Paginas", "Fecha publicacion");

    foreach (var item in listaDeLibros)
    {
        Console.WriteLine($"{formatoTexto}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGroupo(IEnumerable<IGrouping<int, Book>> ListadeLibros)
{
    string estructuraTexto = "{0,-60} {1,15} {2,15}";
    
    foreach (var grupo in ListadeLibros)
    {
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"Grupo: {grupo.Key}");
        Console.WriteLine($"{estructuraTexto}", "Titulo", "N. Paginas", "Fecha publicación");
        foreach (var item in grupo)
        {
            Console.WriteLine($"{estructuraTexto}", item.Title, item.PageCount, item.PublishedDate.Date.ToShortDateString());
        }
    }
}
#endregion