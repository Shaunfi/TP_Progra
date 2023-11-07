<<<<<<< HEAD
﻿using TPPepas.Entidades;
=======
﻿using Backend.Entidades;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Interfaz
{
    public interface IPedidos
    {
        bool Agregar(Pedidos pedido);
        List<object> Listar();
        List<object> ListarFiltro(DateTime desde, DateTime hasta);
        List<object> ListarFiltro(DateTime desde, DateTime hasta, int sucursal);
        List<object> ListarFiltro(DateTime desde, DateTime hasta, int sucursal, int codPedido);
        List<object> ListarLotes(int nroPedido);
    }
}
