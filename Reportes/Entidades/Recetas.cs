using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Recetas
    {
        private int codReceta;
        private string descripcion;
        private int tipoReceta;
        private int matricula;
        private Productos producto;

        public int CodReceta { get { return codReceta; } set { codReceta = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int TipoReceta { get { return tipoReceta; } set { tipoReceta = value; } }
        public int Matricula { get { return matricula; } set { matricula = value; } }

        public Productos Producto { get { return producto; } set { producto = value; } }

        public Recetas() 
        {
            codReceta = 0;
            descripcion = String.Empty;
            tipoReceta = 0;
            matricula = 0;
            producto = null;
        }

        public Recetas(int codReceta, string descripcion, int tipoReceta, int matricula, Productos producto)
        {
            this.codReceta = codReceta;
            this.descripcion = descripcion;
            this.tipoReceta = tipoReceta;
            this.matricula = matricula;
            this.producto = producto;
        }

        public override string ToString()
        {
            return $"Receta | {Producto.Descripcion} | {matricula}";
        }
    }
}
