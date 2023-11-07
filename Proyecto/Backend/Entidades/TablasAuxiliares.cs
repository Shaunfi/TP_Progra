<<<<<<< HEAD
﻿namespace TPPepas.Entidades
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entidades
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a
{
    public class TablasAuxiliares
    {
        private int valor;
        private string display;

        public TablasAuxiliares(int valor, string display)
        {
            this.valor = valor;
            this.display = display;
        }
        public TablasAuxiliares()
        {
           valor = 0;
           display = String.Empty;
        }

        public int Valor { get => valor; set => valor = value; }
        public string Display { get => display; set => display = value; }
    }
}
