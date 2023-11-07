<<<<<<< HEAD
﻿using TPPepas.Datos.Interfaz;
=======
﻿using Backend.Datos.Interfaz;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Servicio
{
    public interface IServicios
    {
        IClientes Clientes { get; }
        IProductos Productos { get; }
        IPedidos Pedidos { get; }
        IFacturas Facturas { get; }
        ITablasAuxiliares TablasAuxiliares { get; }
        IMedicos Medicos { get; }
        IProveedores Proveedores { get; }
        ILaboratorios Laboratorios { get; }
        ISucursales Sucursales { get; }
        IEmpleados Empleados { get; }
        ILotes Lotes { get; }
        ILogin Login { get; }
    }
}
