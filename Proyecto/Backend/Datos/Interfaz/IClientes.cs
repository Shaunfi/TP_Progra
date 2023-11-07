<<<<<<< HEAD
﻿using Farmacia.Entidades;
=======
﻿using Backend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

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
