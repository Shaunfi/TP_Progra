using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Servicio
{
    public interface IServicios
    {
        IClientes Clientes { get; }
        IProductos Productos { get; }
        IPedidos Pedidos { get; }
        IFacturas Facturas { get; }
        ITablasAuxiliares TablasAuxiliares { get; }

    }
}
