<<<<<<< HEAD
﻿using Farmacia.Entidades;
=======
﻿using Backend.Entidades;
using Microsoft.Data.SqlClient;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a


namespace Backend.Datos.Interfaz
{
    public interface IDetallesFactura
    {
        void Agregar(Facturas factura, SqlTransaction t);
        void ModificarStock(Facturas factura, SqlTransaction t);
        void StockSinVencer(Facturas factura, SqlTransaction t);
    }
}
