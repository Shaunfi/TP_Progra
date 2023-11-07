<<<<<<< HEAD
﻿using TPPepas.Datos.Implementacion;
using TPPepas.Datos.Interfaz;
=======
﻿using Backend.Datos.Implementacion;
using Backend.Datos.Interfaz;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Servicio
{
    public class Servicios : IServicios
    {
        public IClientes Clientes { get; }
        public IProductos Productos { get; }
        public IPedidos Pedidos { get; }
        public IFacturas Facturas { get; }
        public ITablasAuxiliares TablasAuxiliares { get; }
        public IMedicos Medicos { get; }
        public IProveedores Proveedores { get; }
        public ILaboratorios Laboratorios { get; }
        public ISucursales Sucursales { get; }
        public IEmpleados Empleados { get; }
        public ILotes Lotes { get; }
        public ILogin Login { get; }

        public Servicios()
        {
            Clientes = new ClientesDAO();
            Productos = new ProductosDAO();
            Pedidos = new PedidosDAO();
            Facturas = new FacturasDAO();
            TablasAuxiliares = new TablasAuxiliaresDAO();
            Medicos = new MedicosDAO();
            Proveedores = new ProveedoresDAO();
            Laboratorios = new LaboratoriosDAO();
            Sucursales = new SucursalesDAO();
            Empleados = new EmpleadosDAO();
            Lotes = new LotesDAO();
            Login = new LoginDAO();
        }
    }
}
