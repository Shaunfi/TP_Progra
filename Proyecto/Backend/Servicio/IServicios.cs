using Backend.Datos.Interfaz;

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
