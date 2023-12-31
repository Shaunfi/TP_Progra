﻿using Backend.Entidades;

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
