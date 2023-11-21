using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Entidades;
using System.Data;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Datos.Implementacion
{
    public class PedidosDAO : IPedidos
    {
        ILotes daoLotes;

        public bool Agregar(Pedidos pedido)
        {
            bool resultado = true;
            SqlConnection cnn = AccesoDatosDAO.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            List<SqlParameter> listParam = new List<SqlParameter>();
            daoLotes = new LotesDAO();

            try
            {
                cnn.Open();

                t = cnn.BeginTransaction();

                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_tipo_pago", pedido.TipoPago));
                listParam.Add(new SqlParameter("@cod_sucursal", pedido.Sucursal.CodSucursal));
                SqlParameter paramOut = new SqlParameter("@cod_pedido", SqlDbType.Int);
                paramOut.Direction = ParameterDirection.Output;
                listParam.Add(paramOut);

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_PEDIDOS", listParam, t);

                pedido.CodPedido = Convert.ToInt32(paramOut.Value);

                daoLotes.Agregar(pedido, t);

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
    }
}
