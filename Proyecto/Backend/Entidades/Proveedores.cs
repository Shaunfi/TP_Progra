<<<<<<< HEAD
﻿namespace Farmacia.Entidades
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entidades
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a
{
    public class Proveedores
    {
        private int codProveedor;
        private string nombreProveedor;
        private string calle;
        private int altura;
        private int codBarrio;
        private string telefono;
        private string email;

        public int CodProveedor { get { return codProveedor; } set { codProveedor = value; } }
        public string NombreProveedor { get { return nombreProveedor; } set { nombreProveedor = value; } }
        public string Calle { get { return calle; } set { calle = value; } }
        public int Altura { get { return altura; } set { altura = value; } }
        public int CodBarrio { get { return codBarrio; } set { codBarrio = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Proveedores() 
        {
            codProveedor = 0;
            nombreProveedor = String.Empty;
            calle = String.Empty;
            altura = 0;
            codBarrio = 0;
            telefono = String.Empty;
            email = String.Empty;
        }

        public Proveedores(int codProveedor, string nombreProveedor, string calle, int altura, int codBarrio, string telefono, string email)
        {
            this.codProveedor = codProveedor;
            this.nombreProveedor = nombreProveedor;
            this.calle = calle;
            this.altura = altura;
            this.codBarrio = codBarrio;
            this.telefono = telefono;
            this.email = email;
        }
    }
}
