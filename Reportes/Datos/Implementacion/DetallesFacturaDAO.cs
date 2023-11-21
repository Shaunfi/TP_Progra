using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Datos.Implementacion
{
    public class DetallesFacturaDAO : IDetallesFactura
    {
        public void Agregar(Facturas factura, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            foreach (DetallesFactura df in factura.LDetalles)
            {
                listParam.Clear();

                listParam.Add(new SqlParameter("@nro_factura", factura.NroFactura));
                listParam.Add(new SqlParameter("@cod_producto", df.Producto.CodProducto));
                listParam.Add(new SqlParameter("@cantidad", df.Cantidad));
                listParam.Add(new SqlParameter("@pre_unitario", df.Precio));
                listParam.Add(new SqlParameter("@descuento", df.Descuento));
                if (df.Receta != null)
                {
                    listParam.Add(new SqlParameter("@cod_receta", df.Receta.CodReceta));
                }

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_DETALLES_FACTURA", listParam, t);
            }
        }
    }
}
