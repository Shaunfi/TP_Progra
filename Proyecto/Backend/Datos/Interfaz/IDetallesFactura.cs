﻿using Backend.Entidades;
using System.Data.SqlClient;

namespace Backend.Datos.Interfaz
{
    public interface IDetallesFactura
    {
        void Agregar(Facturas factura, SqlTransaction t);
        void ModificarStock(Facturas factura, SqlTransaction t);
        void StockSinVencer(Facturas factura, SqlTransaction t);
    }
}
