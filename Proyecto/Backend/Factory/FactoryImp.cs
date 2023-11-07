<<<<<<< HEAD
﻿using TPPepas.Servicio;
=======
﻿using Backend.Servicio;
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a

namespace Backend.Factory
{
    public class FactoryImp : FactoryAbs
    {
        public override IServicios CrearServicio()
        {
            return new Servicios();
        }
    }
}
