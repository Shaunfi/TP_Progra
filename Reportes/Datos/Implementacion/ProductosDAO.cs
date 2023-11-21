using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Datos.Implementacion
{
    public class ProductosDAO : IProductos
    {
        public List<object> Listar()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PRODUCTOS");

            foreach (DataRow row in tabla.Rows)
            {
                Productos p = new Productos();
                p.CodProducto = Convert.ToInt32(row[0].ToString());
                p.Descripcion = row[1].ToString();
                p.Precio = Convert.ToDouble(row[2].ToString());
                p.StockMinimo = Convert.ToInt32(row[3].ToString());
                p.VentaLibre = row[4].ToString() == "1" ? true : false;
                p.Activo = row[5].ToString() == "1" ? true : false;
                p.TipoProducto = Convert.ToInt32(row[6].ToString());
                p.TipoPresentacion = Convert.ToInt32(row[7].ToString());


                lista.Add(p);
            }

            return lista;
        }

        public bool Agregar(Productos producto)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@descripcion", producto.Descripcion));
            listParam.Add(new SqlParameter("@pre_unitario", producto.Precio));
            listParam.Add(new SqlParameter("@cod_laboratorio", producto.Laboratorio.CodLaboratorio));
            listParam.Add(new SqlParameter("@stock_minimo", producto.StockMinimo));
            listParam.Add(new SqlParameter("@venta_libre", producto.VentaLibre));
            listParam.Add(new SqlParameter("@cod_tipo_prod", producto.TipoProducto));
            listParam.Add(new SqlParameter("@cod_tipo_presentacion", producto.TipoPresentacion));

            return AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_PRODUCTOS", listParam);
        }
    }
}
