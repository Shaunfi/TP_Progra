<<<<<<< HEAD
﻿using Farmacia.Entidades;
using System.Data;
using TPPepas.Datos.Interfaz;
=======
﻿using Backend.Entidades;
using Microsoft.Data.SqlClient;
using System.Data;
using Backend.Datos.Interfaz;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Implementacion
{
    public class RecetasDAO : IRecetas
    {
        public int Agregar(Recetas receta, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cantidad", receta.Cantidad));
            listParam.Add(new SqlParameter("@cod_tipo_receta", receta.TipoReceta));
            listParam.Add(new SqlParameter("@matricula", receta.Medico.Matricula));
            listParam.Add(new SqlParameter("@cod_producto", receta.Producto.CodProducto));
            SqlParameter paramOut = new SqlParameter("@cod_receta", SqlDbType.Int);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_RECETAS", listParam, t);

            return Convert.ToInt32(paramOut.Value);
        }
    }
}
