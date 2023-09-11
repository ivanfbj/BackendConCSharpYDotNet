// See https://aka.ms/new-console-template for more information
Console.WriteLine("Curso de Programación Orientada a Objetos con C#");

// Instanciar una clase nos permite crear un objeto con las propiedades de dicha clase, para esto se utiliza la propiedad "new".
Computador ComputadorAcerNitro5 = new Computador();
Computador ComputadorHpVictus = new Computador();

ComputadorAcerNitro5.Marca = "Acer";
ComputadorHpVictus.Marca = "HP";  
class Computador
{
    public string Marca;
    public string MemoriaRam;
    public string TipoDisco;
    public string CapacidadDisco;
    public string Procesador;
    public string ModeloProcesador;
    public string MarcarTarjetaGrafica;
    public string TarjetaGrafica;
    public string ModeloTarjetaGrafica;
    public string SistemaOperativo;
    public string VersionSistemaOperativo;
    public short NucleosProcesador;
    public string VelocidadProcesador;

}