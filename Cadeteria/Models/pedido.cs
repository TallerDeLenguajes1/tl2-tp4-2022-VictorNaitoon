public class Pedidos{
    static private int PedidosRealizados = 0;

    private int numeroDePedido;
    private string? descripcionPedido;
    private Cliente? cliente;
    private string? estado;

    public int NumeroDePedido { get => numeroDePedido; set => numeroDePedido = value; }
    public string? DescripcionPedido { get => descripcionPedido; set => descripcionPedido = value; }
    public Cliente? Cliente { get => cliente; set => cliente = value; }
    public string? Estado { get => estado; set => estado = value; }

    public Pedidos(string Nombre, string Direccion, string Telefono, string ReferenciaDeDireccion, string DescripcionPedido){
        this.NumeroDePedido = ++PedidosRealizados;
        this.Cliente = new Cliente(Nombre, Direccion, Telefono, ReferenciaDeDireccion);
        this.DescripcionPedido = DescripcionPedido;
        this.Estado = "Pendiente";
    }


    public void CambiarEstado(int opcion){
        switch (opcion)
        {
            case 1: this.Estado = "Pendiente"; break;
            case 2: this.Estado = "En Camino"; break;
            default: this.Estado = "Entregado"; break;
        }
    }
}