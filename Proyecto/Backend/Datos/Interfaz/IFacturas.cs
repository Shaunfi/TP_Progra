using Backend.Entidades;

namespace Backend.Datos.Interfaz
{
    public interface IFacturas
    {
        bool Agregar(Facturas factura);
        List<object> ListarFiltros(DateTime fechaDesde, DateTime fechaHasta, string cliente, int nroFactura);
        bool DarDeBaja(int nroFactura);
        List<object> ListarDetalles(int nroFactura);
    }
}
