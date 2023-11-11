#region Clase 7 - Configurando clases
//public class LinqQueries
//{
//    public LinqQueries()
//    {
        
//    }
//}
#endregion

#region Clase 8 - Importando datos
using System.Text.Json;

namespace cursoDeManejoDeDatosEnCSharpConLINQ;
public class LinqQueries
{
    private List<Book> librosColletion = new();

    public LinqQueries()
    {
        // el StreamReader permite leer el archivo.
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosColletion = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        };

    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosColletion;
    }
}
#endregion