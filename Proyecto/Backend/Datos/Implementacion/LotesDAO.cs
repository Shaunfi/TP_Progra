<<<<<<< HEAD
﻿using TPPepas.Datos.Interfaz;
using TPPepas.Entidades;
=======
﻿using Microsoft.Data.SqlClient;
using Backend.Datos.Interfaz;
using Backend.Entidades;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Implementacion
{
    public class LotesDAO : ILotes
    {
        public void Agregar(Pedidos pedido, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            foreach (Lotes lt in pedido.LLotes)
            {
                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_pedido", pedido.CodPedido));
                listParam.Add(new SqlParameter("@cantidad", lt.Cantidad));
                listParam.Add(new SqlParameter("@pre_unitario", lt.Precio));
                listParam.Add(new SqlParameter("@fecha_vencimiento", lt.FechaVencimiento));
                listParam.Add(new SqlParameter("@cod_producto", lt.Producto.CodProducto));
                listParam.Add(new SqlParameter("@cod_proveedor", lt.Proveedor.CodProveedor));

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_LOTES", listParam, t);
            }
        }
        public void ModificarStock(Pedidos pedido, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            foreach (Lotes lt in pedido.LLotes)
            {
                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_sucursal", pedido.Sucursal.CodSucursal));
                listParam.Add(new SqlParameter("@cod_producto", lt.Producto.CodProducto));
                listParam.Add(new SqlParameter("@cantidad", lt.Cantidad));

                AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_MODIFICAR_STOCK", listParam);
            }
        }
    }
}
