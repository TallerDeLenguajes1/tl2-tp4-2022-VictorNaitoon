public class Cadeterias{
    private string? nombre;
    private string? telefono;
    private List<Cadete>? listadoDeCatedes;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Telefono { get => telefono; set => telefono = value; }
    public List<Cadete>? ListadoDeCatedes { get => listadoDeCatedes; set => listadoDeCatedes = value; }

    public Cadeterias(string Nombre, string Telefono){
        this.Nombre = Nombre;
        this.Telefono = Telefono;
        this.ListadoDeCatedes = new List<Cadete>();
    }

    public void AgregarCadetes(Cadete nuevoCadete){
        this.ListadoDeCatedes.Add(nuevoCadete);
    }

}