<<<<<<< HEAD
﻿using Farmacia.Entidades;
=======
﻿using Backend.Entidades;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Interfaz
{
    public interface IProveedores
    {
        List<object> Listar();
        List<object> ListarFiltro(string nomProv);
        bool Agregar(Proveedores proveedor);
        string ConsultarProveedor(int codProveedor);
    }
}
