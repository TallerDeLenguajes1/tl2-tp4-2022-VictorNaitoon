public class Cadete : Persona {
    List<Pedidos>? listadoDePedidos;
    private float TotalACobrar=0;

    public List<Pedidos>? ListadoDePedidos { get => listadoDePedidos; set => listadoDePedidos = value; }

    public Cadete(string Nombre, string Direccion, string Telefono) : base(Nombre, Direccion, Telefono){
        this.ListadoDePedidos = new List<Pedidos>();
    }

    public void AgregarPedido(Pedidos nuevoPedido){
        this.ListadoDePedidos.Add(nuevoPedido);
    }

    public float JornalACobrar(){
        /*
        foreach (var item in this.ListadoDePedidos)
        {
            if (item.Estado == "Entregado" || item.Estado == "entregado")
            {
                this.TotalACobrar += 300;
            } else {
                this.TotalACobrar += 0;
            }
        }
        */

        //Aplicacion con Linq
        IEnumerable<Pedidos> entregados = from pedidos in ListadoDePedidos where pedidos.Estado == "Entregado" select pedidos;

        foreach (Pedidos item in entregados)
        {
            this.TotalACobrar += 300;
        }

        return TotalACobrar;
    }
}