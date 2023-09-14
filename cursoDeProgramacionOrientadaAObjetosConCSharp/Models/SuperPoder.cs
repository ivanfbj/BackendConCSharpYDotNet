#region Clase 11 - Modificadores de acceso
namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }
}
#endregion