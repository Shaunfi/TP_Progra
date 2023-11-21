using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class DetallesFactura
    {
        private int codDetalle;
        private Productos producto;
        private Recetas receta;
        private int cantidad;
        private double precio;
        private double descuento;

        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public Productos Producto { get => producto; set => producto = value; }
        public int CodDetalle { get => codDetalle; set => codDetalle = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public Recetas Receta { get => receta; set => receta = value; }

        public DetallesFactura() 
        {
            cantidad = 0;
            precio = 0;
            Producto = null;
            codDetalle = 0;
            descuento = 0;
            receta = null;
        }

        public DetallesFactura(Productos producto, int cantidad, double precio, double descuento, Recetas receta)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
            this.descuento = descuento;
            this.receta = receta;
        } 
    }
}
