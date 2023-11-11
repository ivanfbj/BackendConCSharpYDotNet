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
//using System.Text.Json;

//namespace cursoDeManejoDeDatosEnCSharpConLINQ;
//public class LinqQueries
//{
//    private List<Book> librosCollection = new();

//    public LinqQueries()
//    {
//        // el StreamReader permite leer el archivo.
//        using (StreamReader reader = new StreamReader("books.json"))
//        {
//            string json = reader.ReadToEnd();
//            this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
//        };

//    }

//    public IEnumerable<Book> TodaLaColeccion()
//    {
//        return librosCollection;
//    }

//    public IEnumerable<Book> LibrosDespuesDel2000()
//    {
//        //extension method
//        //return librosColletion.Where(p=> p.PublishedDate.Year > 2000);

//        //query expresion
//        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
//    }

//    public IEnumerable<Book> LibrosMasDeCantidadPagsYPalabraClave(int cantidadPaginas, string palabraClave)
//    {
//        //extension method
//        //return librosCollection.Where(p => p.PageCount > cantidadPaginas && p.Title.Contains(palabraClave));

//        //query expresion
//        return from l in librosCollection where l.PageCount > cantidadPaginas && l.Title.Contains(palabraClave)
//               select l;
//    }
//}
#endregion

#region Clase 11 - Operadores All y Any
//using System.Text.Json;

//namespace cursoDeManejoDeDatosEnCSharpConLINQ;
//public class LinqQueries
//{
//    private List<Book> librosCollection = new();

//    public LinqQueries()
//    {
//        // el StreamReader permite leer el archivo.
//        using (StreamReader reader = new StreamReader("books.json"))
//        {
//            string json = reader.ReadToEnd();
//            this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
//        };

//    }

//    public IEnumerable<Book> TodaLaColeccion()
//    {
//        return librosCollection;
//    }

//    public IEnumerable<Book> LibrosDespuesDel2000()
//    {
//        //extension method
//        //return librosColletion.Where(p=> p.PublishedDate.Year > 2000);

//        //query expresion
//        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
//    }

//    public IEnumerable<Book> LibrosMasDeCantidadPagsYPalabraClave(int cantidadPaginas, string palabraClave)
//    {
//        //extension method
//        //return librosCollection.Where(p => p.PageCount > cantidadPaginas && p.Title.Contains(palabraClave));

//        //query expresion
//        return from l in librosCollection
//               where l.PageCount > cantidadPaginas && l.Title.Contains(palabraClave)
//               select l;
//    }

//    public bool TodosLosLibrosTienenStatus()
//    {
//        return librosCollection.All(p => p.Status != string.Empty);
//    }

//    public bool SiAlgunLibroPublicadoEn2005()
//    {
//        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
//    }
//}
#endregion

#region Clase 12 - Operador Contains
//using System.Text.Json;

//namespace cursoDeManejoDeDatosEnCSharpConLINQ;
//public class LinqQueries
//{
//    private List<Book> librosCollection = new();

//    public LinqQueries()
//    {
//        // el StreamReader permite leer el archivo.
//        using (StreamReader reader = new StreamReader("books.json"))
//        {
//            string json = reader.ReadToEnd();
//            this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
//        };

//    }

//    public IEnumerable<Book> TodaLaColeccion()
//    {
//        return librosCollection;
//    }

//    public IEnumerable<Book> LibrosDespuesDel2000()
//    {
//        //extension method
//        //return librosColletion.Where(p=> p.PublishedDate.Year > 2000);

//        //query expresion
//        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
//    }

//    public IEnumerable<Book> LibrosMasDeCantidadPagsYPalabraClave(int cantidadPaginas, string palabraClave)
//    {
//        //extension method
//        //return librosCollection.Where(p => p.PageCount > cantidadPaginas && p.Title.Contains(palabraClave));

//        //query expresion
//        return from l in librosCollection
//               where l.PageCount > cantidadPaginas && l.Title.Contains(palabraClave)
//               select l;
//    }

//    public bool TodosLosLibrosTienenStatus()
//    {
//        return librosCollection.All(p => p.Status != string.Empty);
//    }

//    public bool SiAlgunLibroPublicadoEn2005()
//    {
//        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
//    }

//    public IEnumerable<Book> LibrosDePython()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Python"));
//    }
//}
#endregion

# region Clase 13 - Operadores OrderBy y OrderByDescending
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
        return from l in librosCollection
               where l.PageCount > cantidadPaginas && l.Title.Contains(palabraClave)
               select l;
    }

    public bool TodosLosLibrosTienenStatus()
    {
        return librosCollection.All(p => p.Status != string.Empty);
    }

    public bool SiAlgunLibroPublicadoEn2005()
    {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }

    public IEnumerable<Book> LibrosDePython()
    {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
    }

    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
    }

    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }

}
#endregion