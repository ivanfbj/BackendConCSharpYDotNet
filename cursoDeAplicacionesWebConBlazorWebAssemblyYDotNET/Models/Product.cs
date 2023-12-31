namespace cursoDeAplicacionesWebConBlazorWebAssemblyYDotNET;

public class Product
{
    public long Id { get; set; }
    public string Title { get; set; }
    public decimal? Price { get; set; }
    public string Description { get; set; }
    public int Category { get; set; }
    public string[] Images { get; set; }
    public string? Image { get; set; }
}

