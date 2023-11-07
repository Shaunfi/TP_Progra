using System.Data;
<<<<<<< HEAD
using TPPepas.Datos.Interfaz;
=======
using Backend.Datos.Interfaz;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

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
