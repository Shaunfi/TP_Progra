using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface IFacturas
    {
        bool Agregar(Facturas factura);
        List<object> ListarFacturaFiltros(DateTime fechaDesde, DateTime fechaHasta, string cliente, int nroFactura);
    }
}
