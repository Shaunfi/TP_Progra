using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Entidades
{
     public class Lotes
    {
        private int codLote;
        private int cantidad;
        private double precio;
        private Proveedores provedoor;
        private Productos producto;
        private DateTime fechaVencimiento;

        public Lotes(int codLote, int cantidad, double precio, Proveedores provedoor, Productos producto, DateTime fechaVencimiento)
        {
            this.CodLote = codLote;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Provedoor = provedoor;
            this.Producto = producto;
            this.FechaVencimiento = fechaVencimiento;
        }

        public Lotes()
        {
            this.CodLote = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Provedoor = null;
            this.Producto = null;
            this.FechaVencimiento = DateTime.Now;
        }

        public int CodLote { get => codLote; set => codLote = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public Proveedores Provedoor { get => provedoor; set => provedoor = value; }
        public Productos Producto { get => producto; set => producto = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    }
}
