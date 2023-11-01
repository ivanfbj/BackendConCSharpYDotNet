using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Clase 18 - Usando interfaces
namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string IdentidadSecreta { get; set; }
    }
}
#endregion