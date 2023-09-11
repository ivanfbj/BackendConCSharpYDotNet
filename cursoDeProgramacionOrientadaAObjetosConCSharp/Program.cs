// See https://aka.ms/new-console-template for more information
Console.WriteLine("Curso de Programación Orientada a Objetos con C#");

#region ## Clase 4 - Creando tu primera clase y objeto
//// Instanciar una clase nos permite crear un objeto con las propiedades de dicha clase, para esto se utiliza la propiedad "new".
//Computador ComputadorAcerNitro5 = new Computador();
//Computador ComputadorHpVictus = new Computador();

//ComputadorAcerNitro5.Marca = "Acer";
//ComputadorHpVictus.Marca = "HP";  
//class Computador
//{
//    public string Marca;
//    public string MemoriaRam;
//    public string TipoDisco;
//    public string CapacidadDisco;
//    public string Procesador;
//    public string ModeloProcesador;
//    public string MarcarTarjetaGrafica;
//    public string TarjetaGrafica;
//    public string ModeloTarjetaGrafica;
//    public string SistemaOperativo;
//    public string VersionSistemaOperativo;
//    public short NucleosProcesador;
//    public string VelocidadProcesador;

//}
#endregion

#region Clase 6 - Creando clases y propiedades

//SuperHeroe superman = new();

//superman.Id = 1;
//superman.Nombre = "Superman";
//superman.IdentidadSecreta = "Clark Kent";
//superman.Ciudad = "Metropolis";
//superman.PuedeVolar = true;
//superman.SuperPoderes = new[] {"Vision de rayos X", "Volar", "Super fuerza", "Ojos rayos laser" };

//class SuperHeroe
//{
//    public int Id;
//    public string Nombre;
//    public string IdentidadSecreta;
//    public String Ciudad;
//    public string[] SuperPoderes;
//    public bool PuedeVolar;
//}
#endregion

#region Clase 7 - Creando clases complejas

SuperPoder poderVolar = new();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

SuperPoder superFuerza = new();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

SuperHeroe superman = new();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

//Alternativa 1
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);

superman.SuperPoderes = poderesSuperman;
//Alternativa 2
/*
List<SuperPoder> poderesSuperman = new List<SuperPoder> { poderVolar, superFuerza };
superman.SuperPoderes = poderesSuperman;
 */

class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public String Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
#endregion