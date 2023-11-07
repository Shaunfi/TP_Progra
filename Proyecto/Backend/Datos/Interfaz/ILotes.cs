using Backend.Entidades;

namespace Backend.Datos.Interfaz
{
    public interface ILotes
    {
        void Agregar(Pedidos pedido, SqlTransaction t);
        void ModificarStock(Pedidos pedido, SqlTransaction t);
    }
}
