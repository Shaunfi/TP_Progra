using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;
using System.Data;

namespace TPPepas.Datos.Implementacion
{
    public class FacturasDAO : IFacturas
    {
        IDetallesFactura daoDetalles;
        public bool Agregar(Facturas factura)
        {
            bool resultado = true;
            SqlConnection cnn = AccesoDatosDAO.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            List<SqlParameter> listParam = new List<SqlParameter>();
            daoDetalles = new DetallesFacturaDAO();

            try
            {
                cnn.Open();

                t = cnn.BeginTransaction();

                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_empleado", factura.Empleado.CodEmpleado));
                listParam.Add(new SqlParameter("@cod_cliente", factura.Cliente.CodCliente));
                listParam.Add(new SqlParameter("@cod_sucursal", factura.Sucursal.CodSucursal));
                listParam.Add(new SqlParameter("@cod_tipo_pago", factura.TipoPago));
                SqlParameter paramOut = new SqlParameter("@nro_factura", SqlDbType.Int);
                paramOut.Direction = ParameterDirection.Output;
                listParam.Add(paramOut);

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_FACTURAS", listParam, t);

                factura.NroFactura = Convert.ToInt32(paramOut.Value);

                daoDetalles.Agregar(factura, t);

                t?.Commit();
            }
            catch
            {
                t?.Rollback();
                resultado = false;
            }
            finally
            {
                cnn.Close();
            }
            return resultado;
        }

        public List<object> ListarFacturaFiltros(DateTime fechaDesde, DateTime fechaHasta, string cliente, int nroFactura)
        {
            List<object> listFacturas = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@fecha_desde", fechaDesde));
            listParam.Add(new SqlParameter("@fecha_hasta", fechaHasta));
            listParam.Add(new SqlParameter("@cliente", cliente));
            if (nroFactura != 0)
            {
                listParam.Add(new SqlParameter("@nro_factura", nroFactura));
            }

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_FACTURAS_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Facturas f = new Facturas();

                f.NroFactura = Convert.ToInt32(row[0].ToString());
                f.Fecha = Convert.ToDateTime(row[1].ToString());
                f.Empleado = new Empleados(Convert.ToInt32(row[2].ToString()));
                f.Cliente = new Clientes(Convert.ToInt32(row[3].ToString()));
                f.Sucursal = new Sucursales(Convert.ToInt32(row[4].ToString()));
                f.TipoPago = Convert.ToInt32(row[5].ToString());

                listFacturas.Add(f);
            }
            return listFacturas;
        }
    }
}
