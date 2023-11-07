using Backend.Entidades;

namespace Backend.Datos.Interfaz
{
    public interface IRecetas
    {
        int Agregar(Recetas receta, SqlTransaction t);
    }
}
