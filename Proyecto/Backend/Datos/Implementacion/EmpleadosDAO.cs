<<<<<<< HEAD
﻿using System.Data;
using TPPepas.Datos.Interfaz;
=======
﻿using Microsoft.Data.SqlClient;
using System.Data;
using Backend.Datos.Interfaz;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Implementacion
{
    public class EmpleadosDAO : IEmpleados
    {
        public string ConsultarEmpleado(int idEmpleado)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_empleado", idEmpleado));
            SqlParameter paramOut = new SqlParameter("@empleado", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_EMPLEADO_FILTRO", listParam);

            return paramOut.Value.ToString();
        }
    }
}
