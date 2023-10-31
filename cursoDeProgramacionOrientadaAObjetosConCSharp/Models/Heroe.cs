using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Clase 15 - Abstracción
namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }

        public abstract string SalvarElMundo();

        public string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la tierra";
        }
    }
}
#endregion