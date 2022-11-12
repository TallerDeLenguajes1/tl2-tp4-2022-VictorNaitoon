public class Persona{
    private int id;
    private string? nombre;
    private string? direccion;
    private string? telefono;

    public int Id { get => id; set => id = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Direccion { get => direccion; set => direccion = value; }
    public string? Telefono { get => telefono; set => telefono = value; }

    static private int incrementar = 0;

    public Persona(string Nombre, string Direccion, string Telefono){
        this.Id = incrementar++;
        this.Nombre = Nombre;
        this.Direccion = Direccion;
        this.Telefono = Telefono;
    }
}