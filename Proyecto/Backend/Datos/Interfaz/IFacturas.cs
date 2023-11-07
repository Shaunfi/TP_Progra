<<<<<<< HEAD
﻿using Farmacia.Entidades;
=======
﻿using Backend.Entidades;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Interfaz
{
    public interface IFacturas
    {
        bool Agregar(Facturas factura);
        List<object> ListarFiltros(DateTime fechaDesde, DateTime fechaHasta, string cliente, int nroFactura);
        bool DarDeBaja(int nroFactura);
        List<object> ListarDetalles(int nroFactura);
    }
}
