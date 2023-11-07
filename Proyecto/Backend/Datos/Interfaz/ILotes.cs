<<<<<<< HEAD
﻿using TPPepas.Entidades;
=======
﻿using Backend.Entidades;
using Microsoft.Data.SqlClient;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Datos.Interfaz
{
    public interface ILotes
    {
        void Agregar(Pedidos pedido, SqlTransaction t);
        void ModificarStock(Pedidos pedido, SqlTransaction t);
    }
}
