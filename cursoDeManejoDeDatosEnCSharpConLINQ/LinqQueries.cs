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

#region Clase 13 - Operadores OrderBy y OrderByDescending
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//}
#endregion

#region Clase 15 - Operadores Take y Skip
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
//    {
//        return librosCollection
//            .Where(p => p.Categories.Contains("Java"))
//            .OrderByDescending(p => p.PublishedDate)
//            .Take(3);
//    }

//    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
//    {
//        return librosCollection
//            .Where(p=> p.PageCount > 400)
//            .Take(4)
//            .Skip(2);
//    }

//}
#endregion

#region Clase 16 - Selección dinámica de datos
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
//    {
//        return librosCollection
//            .Where(p => p.Categories.Contains("Java"))
//            .OrderByDescending(p => p.PublishedDate)
//            .Take(3);
//    }

//    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
//    {
//        return librosCollection
//            .Where(p => p.PageCount > 400)
//            .Take(4)
//            .Skip(2);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
//    {
//        return librosCollection.Take(3)
//            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
//    }
//}
#endregion

#region Clase 17 - Operadores LongCount y Count
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
//    {
//        return librosCollection
//            .Where(p => p.Categories.Contains("Java"))
//            .OrderByDescending(p => p.PublishedDate)
//            .Take(3);
//    }

//    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
//    {
//        return librosCollection
//            .Where(p => p.PageCount > 400)
//            .Take(4)
//            .Skip(2);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
//    {
//        return librosCollection.Take(3)
//            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
//    }

//    public int CantidadDeLibrosEntre200y500Pags()
//    {
//        //Esta es una forma de retornar la información ya que se puede aplicar el Count 
//        // despues de filtrar con el Where
//        //return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();

//        //Una mejor práctica es hacer el filtro directamente con el Count:
//        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
//    }
//}
#endregion

#region Clase 18 - Operadores Min y Max
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
//    {
//        return librosCollection
//            .Where(p => p.Categories.Contains("Java"))
//            .OrderByDescending(p => p.PublishedDate)
//            .Take(3);
//    }

//    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
//    {
//        return librosCollection
//            .Where(p => p.PageCount > 400)
//            .Take(4)
//            .Skip(2);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
//    {
//        return librosCollection.Take(3)
//            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
//    }

//    public int CantidadDeLibrosEntre200y500Pags()
//    {
//        //Esta es una forma de retornar la información ya que se puede aplicar el Count 
//        // despues de filtrar con el Where
//        //return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();

//        //Una mejor práctica es hacer el filtro directamente con el Count:
//        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
//    }

//    public DateTime FechaDePublicacionMenor()
//    {
//        return librosCollection.Min(p => p.PublishedDate);
//    }

//    public int NumeroDePagsLibroMayor()
//    {
//        return librosCollection.Max(p => p.PageCount);
//    }

//}
#endregion

#region Clase 19 - Operadores MinBy y MaxBy
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
//    {
//        return librosCollection
//            .Where(p => p.Categories.Contains("Java"))
//            .OrderByDescending(p => p.PublishedDate)
//            .Take(3);
//    }

//    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
//    {
//        return librosCollection
//            .Where(p => p.PageCount > 400)
//            .Take(4)
//            .Skip(2);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
//    {
//        return librosCollection.Take(3)
//            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
//    }

//    public int CantidadDeLibrosEntre200y500Pags()
//    {
//        //Esta es una forma de retornar la información ya que se puede aplicar el Count 
//        // despues de filtrar con el Where
//        //return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();

//        //Una mejor práctica es hacer el filtro directamente con el Count:
//        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
//    }

//    public DateTime FechaDePublicacionMenor()
//    {
//        return librosCollection.Min(p => p.PublishedDate);
//    }

//    public int NumeroDePagsLibroMayor()
//    {
//        return librosCollection.Max(p => p.PageCount);
//    }

//    public Book LibroConMenorNumeroDePaginas()
//    {
//        return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
//    }

//    public Book LibroConFechaPublicacionMasReciente()
//    {
//        return librosCollection.MaxBy(p => p.PublishedDate);
//    }
//}
#endregion

#region Clase 20 - Operadores Sum y Aggregate
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
//    {
//        return librosCollection
//            .Where(p => p.Categories.Contains("Java"))
//            .OrderByDescending(p => p.PublishedDate)
//            .Take(3);
//    }

//    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
//    {
//        return librosCollection
//            .Where(p => p.PageCount > 400)
//            .Take(4)
//            .Skip(2);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
//    {
//        return librosCollection.Take(3)
//            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
//    }

//    public int CantidadDeLibrosEntre200y500Pags()
//    {
//        //Esta es una forma de retornar la información ya que se puede aplicar el Count 
//        // despues de filtrar con el Where
//        //return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();

//        //Una mejor práctica es hacer el filtro directamente con el Count:
//        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
//    }

//    public DateTime FechaDePublicacionMenor()
//    {
//        return librosCollection.Min(p => p.PublishedDate);
//    }

//    public int NumeroDePagsLibroMayor()
//    {
//        return librosCollection.Max(p => p.PageCount);
//    }

//    public Book LibroConMenorNumeroDePaginas()
//    {
//        return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
//    }

//    public Book LibroConFechaPublicacionMasReciente()
//    {
//        return librosCollection.MaxBy(p => p.PublishedDate);
//    }

//    public int SumaDeTodasLasPaginasLibrosEntre0y500()
//    {
//        return librosCollection.Where(p => p.PageCount >= 0 && p.PageCount <= 500).Sum(p => p.PageCount);
//    }

//    public string TitulosLibrosDespuesDel2015Concatenados()
//    {
//        return librosCollection
//            .Where(p => p.PublishedDate.Year > 2015)
//            .Aggregate("", (TitulosLibros, next) =>
//            {
//                if (TitulosLibros != string.Empty)
//                {
//                    TitulosLibros += " - " + next.Title;
//                }
//                else
//                {
//                    TitulosLibros += next.Title;
//                }

//                return TitulosLibros;
//            });
//    }
//}
#endregion

#region Clase 21 - Operador Average
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

//    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
//    {
//        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
//    }

//    public IEnumerable<Book> LibrosMasDe450PagsOrdenadosPorNumPagDescendente()
//    {
//        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
//    {
//        return librosCollection
//            .Where(p => p.Categories.Contains("Java"))
//            .OrderByDescending(p => p.PublishedDate)
//            .Take(3);
//    }

//    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
//    {
//        return librosCollection
//            .Where(p => p.PageCount > 400)
//            .Take(4)
//            .Skip(2);
//    }

//    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
//    {
//        return librosCollection.Take(3)
//            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
//    }

//    public int CantidadDeLibrosEntre200y500Pags()
//    {
//        //Esta es una forma de retornar la información ya que se puede aplicar el Count 
//        // despues de filtrar con el Where
//        //return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();

//        //Una mejor práctica es hacer el filtro directamente con el Count:
//        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
//    }

//    public DateTime FechaDePublicacionMenor()
//    {
//        return librosCollection.Min(p => p.PublishedDate);
//    }

//    public int NumeroDePagsLibroMayor()
//    {
//        return librosCollection.Max(p => p.PageCount);
//    }

//    public Book LibroConMenorNumeroDePaginas()
//    {
//        return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
//    }

//    public Book LibroConFechaPublicacionMasReciente()
//    {
//        return librosCollection.MaxBy(p => p.PublishedDate);
//    }

//    public int SumaDeTodasLasPaginasLibrosEntre0y500()
//    {
//        return librosCollection.Where(p => p.PageCount >= 0 && p.PageCount <= 500).Sum(p => p.PageCount);
//    }

//    public string TitulosLibrosDespuesDel2015Concatenados()
//    {
//        return librosCollection
//            .Where(p => p.PublishedDate.Year > 2015)
//            .Aggregate("", (TitulosLibros, next) =>
//            {
//                if (TitulosLibros != string.Empty)
//                {
//                    TitulosLibros += " - " + next.Title;
//                }
//                else
//                {
//                    TitulosLibros += next.Title;
//                }

//                return TitulosLibros;
//            });
//    }

//    public double PromedioCaracteresTitulo()
//    {
//        return librosCollection.Average(p => p.Title.Length);
//    }
//}
#endregion

#region Clase 22 - Cláusula GroupBy
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

    public IEnumerable<Book> TresPrimerosLibrosJavaOrdenadosPorFecha()
    {
        return librosCollection
            .Where(p => p.Categories.Contains("Java"))
            .OrderByDescending(p => p.PublishedDate)
            .Take(3);
    }

    public IEnumerable<Book> TerceryCuartoLibroDeMas400Pags()
    {
        return librosCollection
            .Where(p => p.PageCount > 400)
            .Take(4)
            .Skip(2);
    }

    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
    {
        return librosCollection.Take(3)
            .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
    }

    public int CantidadDeLibrosEntre200y500Pags()
    {
        //Esta es una forma de retornar la información ya que se puede aplicar el Count 
        // despues de filtrar con el Where
        //return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();

        //Una mejor práctica es hacer el filtro directamente con el Count:
        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
    }

    public DateTime FechaDePublicacionMenor()
    {
        return librosCollection.Min(p => p.PublishedDate);
    }

    public int NumeroDePagsLibroMayor()
    {
        return librosCollection.Max(p => p.PageCount);
    }

    public Book LibroConMenorNumeroDePaginas()
    {
        return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
    }

    public Book LibroConFechaPublicacionMasReciente()
    {
        return librosCollection.MaxBy(p => p.PublishedDate);
    }

    public int SumaDeTodasLasPaginasLibrosEntre0y500()
    {
        return librosCollection.Where(p => p.PageCount >= 0 && p.PageCount <= 500).Sum(p => p.PageCount);
    }

    public string TitulosLibrosDespuesDel2015Concatenados()
    {
        return librosCollection
            .Where(p => p.PublishedDate.Year > 2015)
            .Aggregate("", (TitulosLibros, next) =>
            {
                if (TitulosLibros != string.Empty)
                {
                    TitulosLibros += " - " + next.Title;
                }
                else
                {
                    TitulosLibros += next.Title;
                }

                return TitulosLibros;
            });
    }

    public double PromedioCaracteresTitulo()
    {
        return librosCollection.Average(p => p.Title.Length);
    }

    public IEnumerable<IGrouping<int, Book>> LibrosDespuesDel2000AgrupadosPorAno()
    {
        return librosCollection.Where(l => l.PublishedDate.Year >= 2000).GroupBy(l=> l.PublishedDate.Year);
    }
}
#endregion