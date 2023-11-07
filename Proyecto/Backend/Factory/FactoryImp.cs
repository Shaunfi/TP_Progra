using TPPepas.Servicio;

namespace TPPepas.Factory
{
    public class FactoryImp : FactoryAbs
    {
        public override IServicios CrearServicio()
        {
            return new Servicios();
        }
    }
}
