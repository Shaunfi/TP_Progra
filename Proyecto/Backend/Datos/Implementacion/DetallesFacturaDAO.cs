using Backend.Entidades;
using System.Data.SqlClient;
using Backend.Datos.Interfaz;

namespace Backend.Datos.Implementacion
{
    public class DetallesFacturaDAO : IDetallesFactura
    {
        IRecetas daoRecetas;

        public void StockSinVencer(Facturas factura, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            foreach (DetallesFactura df in factura.LDetalles)
            {
                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_sucursal", factura.Sucursal.CodSucursal));
                listParam.Add(new SqlParameter("@cod_producto", df.Producto.CodProducto));

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_STOCK_FECHA_VENCIMIENTO", listParam, t);
            }

        }

        public void Agregar(Facturas factura, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            daoRecetas = new RecetasDAO();

            foreach (DetallesFactura df in factura.LDetalles)
            {
                listParam.Clear();

                listParam.Add(new SqlParameter("@nro_factura", factura.NroFactura));
                listParam.Add(new SqlParameter("@cod_producto", df.Producto.CodProducto));
                listParam.Add(new SqlParameter("@cantidad", df.Cantidad));
                listParam.Add(new SqlParameter("@pre_unitario", df.Precio));
                if (df.Receta.Medico.Matricula != 0)
                {
                    df.Receta.CodReceta = daoRecetas.Agregar(df.Receta, t);
                    listParam.Add(new SqlParameter("@cod_receta", df.Receta.CodReceta));
                }
                else
                {
                    listParam.Add(new SqlParameter("@cod_receta", null));
                }
                listParam.Add(new SqlParameter("@descuento", df.Descuento));

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_DETALLES_FACTURA", listParam, t);
            }
        }

        public void ModificarStock(Facturas factura, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            
            
            foreach (DetallesFactura df in factura.LDetalles)
            {
                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_sucursal", factura.Sucursal.CodSucursal));
                listParam.Add(new SqlParameter("@cod_producto", df.Producto.CodProducto));
                listParam.Add(new SqlParameter("@cantidad", df.Cantidad));

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_MODIFICAR_STOCK", listParam, t);
            }
        }
    }
}
