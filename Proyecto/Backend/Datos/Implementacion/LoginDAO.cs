using System.Data;
using Backend.Datos.Interfaz;

namespace Backend.Datos.Implementacion
{
    public class LoginDAO : ILogin
    {
        public int ConsultarLogin(string usuario, string password)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@usuario", usuario));
            listParam.Add(new SqlParameter("@contra", password));
            SqlParameter paramOut = new SqlParameter("@cod_sucursal", SqlDbType.Int);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_LOGIN", listParam);

            return (int)paramOut.Value;
        }
    }
}
