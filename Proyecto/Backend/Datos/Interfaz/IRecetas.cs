using Backend.Entidades;
using Microsoft.Data.SqlClient;

namespace Backend.Datos.Interfaz
{
    public interface IRecetas
    {
        int Agregar(Recetas receta, SqlTransaction t);
    }
}
