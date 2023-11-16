using Backend.Entidades;

namespace Backend.Datos.Interfaz
{
    public interface IProductos
    {
        List<object> Listar();
        bool Agregar(Productos producto);
        List<object> ListarFiltro(int tipoProducto);
        List<object> ListarFiltro(string descripcion, int tipoProducto);
        double ConsultarDescuento(Productos producto, Clientes cliente);
        bool DeshabilitarProducto(int codProducto);
        string ConsultarProducto(int codProducto);
        int ConsultarStock(int codProducto, int codSucursal);
    }
}
