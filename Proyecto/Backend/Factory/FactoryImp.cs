using Backend.Servicio;

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
