﻿using Farmacia.Entidades;

namespace TPPepas.Datos.Interfaz
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
