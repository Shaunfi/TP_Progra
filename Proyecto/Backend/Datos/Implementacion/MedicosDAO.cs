using System.Data;
using Backend.Datos.Interfaz;

namespace Backend.Datos.Implementacion
{
    public class MedicosDAO : IMedicos
    {
        public bool ConfirmarMedico(int matricula)
        {
            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_MEDICOS");

            foreach (DataRow row in tabla.Rows)
            {
                if (Convert.ToInt32(row[0].ToString()) == matricula)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
