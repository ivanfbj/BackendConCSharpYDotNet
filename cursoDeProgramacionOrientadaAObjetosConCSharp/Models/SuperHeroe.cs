using System.Text;
#region Clase 11 - Modificadores de acceso
namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
{
    class SuperHeroe
    {
        public int Id;
        public string Nombre;
        public string IdentidadSecreta;
        public String Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} está usando el super poder {item.Nombre}!!");
            }

            return sb.ToString();
        }
    }
}
#endregion