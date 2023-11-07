using Farmacia.Entidades;

namespace TPPepas.Datos.Interfaz
{
    public interface ISucursales
    {
        List<object> Listar();
        Sucursales ConsultarObjetoSucursal(int idSucursal);
        string ConsultarSucursal(int idSucursal);
    }
}
