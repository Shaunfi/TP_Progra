using Backend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Datos.Interfaz
{
    public interface IClientes
    {
        List<object> Listar();
        bool Agregar(Clientes cliente);
        bool Modificar(Clientes cliente);
        List<object> ListarFiltro(string cliente);
        List<object> ListarFiltro(string cliente, int nroDoc);
        string ConsultarCliente(int idCliente);
    }
}
