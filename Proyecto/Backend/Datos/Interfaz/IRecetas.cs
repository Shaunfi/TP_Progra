using Farmacia.Entidades;

namespace TPPepas.Datos.Interfaz
{
    public interface IRecetas
    {
        int Agregar(Recetas receta, SqlTransaction t);
    }
}
