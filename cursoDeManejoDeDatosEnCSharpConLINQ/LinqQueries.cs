#region Clase 7 - Configurando clases
//public class LinqQueries
//{
//    public LinqQueries()
//    {

//    }
//}
#endregion

#region Clase 8 - Importando datos
//using System.Text.Json;

//namespace cursoDeManejoDeDatosEnCSharpConLINQ;
//public class LinqQueries
//{
//    private List<Book> librosColletion = new();

//    public LinqQueries()
//    {
//        // el StreamReader permite leer el archivo.
//        using (StreamReader reader = new StreamReader("books.json"))
//        {
//            string json = reader.ReadToEnd();
//            this.librosColletion = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
//        };

//    }

//    public IEnumerable<Book> TodaLaColeccion()
//    {
//        return librosColletion;
//    }
//}
#endregion

#region Clase 9 - Usando el operador Where
using System.Text.Json;

namespace cursoDeManejoDeDatosEnCSharpConLINQ;
public class LinqQueries
{
    private List<Book> librosCollection = new();

    public LinqQueries()
    {
        // el StreamReader permite leer el archivo.
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        };

    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDespuesDel2000()
    {
        //extension method
        //return librosColletion.Where(p=> p.PublishedDate.Year > 2000);

        //query expresion
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> LibrosMasDeCantidadPagsYPalabraClave(int cantidadPaginas, string palabraClave)
    {
        //extension method
        //return librosCollection.Where(p => p.PageCount > cantidadPaginas && p.Title.Contains(palabraClave));

        //query expresion
        return from l in librosCollection where l.PageCount > cantidadPaginas && l.Title.Contains(palabraClave)
               select l;
    }
}
#endregion