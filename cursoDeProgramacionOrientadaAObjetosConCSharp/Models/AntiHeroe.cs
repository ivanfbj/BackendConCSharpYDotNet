using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Clase 14 - Usando herencia en C#
namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiheroe(string accion)
        {
            return $"El Antiheroe {NombreEidentidadSecreta} ha realizado: {accion}";
        }
    }
}
#endregion