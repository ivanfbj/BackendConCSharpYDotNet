#region Clase 8 - Importando datos
using cursoDeManejoDeDatosEnCSharpConLINQ;

Console.WriteLine("Curso de Manejo de Datos en C# con LINQ");
Console.WriteLine("***************************************************************************************************************");

LinqQueries queries = new LinqQueries();

ImprimirValores(queries.TodaLaColeccion());

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