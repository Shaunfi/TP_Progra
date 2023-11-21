using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface ITablasAuxiliares
    {
        List<object> ListarTiposProductos();
        List<object> ListarTiposPresentacion();
        List<object> ListarTiposVentas();
    }
}
