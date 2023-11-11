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

//Libros después del 2000
Console.WriteLine("Libros después del 2000");
ImprimirValores(queries.LibrosDespuesDel2000());
Console.WriteLine("*****************************");

//Libros con más 250 páginas y título contenga "in Action"
Console.WriteLine("Libros con más 250 páginas y título contenga \"in Action\"");
ImprimirValores(queries.LibrosMasDeCantidadPagsYPalabraClave(250,"in Action"));
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
#endregion