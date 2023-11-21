using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Entidades;

namespace TPPepas.Datos.Interfaz
{
    public interface IPedidos
    {
        bool Agregar(Pedidos pedido);
    }
}
