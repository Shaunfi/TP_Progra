using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;
using TPPepas.Entidades;

namespace TPPepas.Datos.Implementacion
{
    public class TablasAuxiliaresDAO : ITablasAuxiliares
    {
        public List<object> ListarTiposProductos()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_PRODUCTOS");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarTiposPresentacion()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_PRESENTACIONES");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarTiposVentas()
        {
            List<object> lista = new List<object>();
            TablasAuxiliares elemento = new TablasAuxiliares();
            elemento.Valor = 0;
            elemento.Display = "No Libre";
            lista.Add(elemento);
            TablasAuxiliares elemento2 = new TablasAuxiliares();
            elemento2.Valor = 1;
            elemento2.Display = "Libre";
            lista.Add(elemento2);

            return lista;
        }
        /*
        public List<object> ListarBarrios()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_BARRIOS");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }
        */
    }
}
