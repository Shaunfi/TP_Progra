<<<<<<< HEAD
﻿using Farmacia.Entidades;
=======
﻿using Backend.Entidades;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Interfaz
{
    public interface IProductos
    {
        List<object> Listar();
        bool Agregar(Productos producto);
        List<object> ListarFiltro(int tipoProducto);
        List<object> ListarFiltro(string descripcion, int tipoProducto);
        double ConsultarDescuento(Productos producto, Clientes cliente);
        bool DeshabilitarProducto(Productos producto);
        string ConsultarProducto(int codProducto);
        int ConsultarStock(int codProducto, int codSucursal);
    }
}
