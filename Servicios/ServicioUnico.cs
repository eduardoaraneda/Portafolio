namespace Portafolio.Servicios
{
    public class ServicioDelimitido
    {
        public ServicioDelimitido()
        {
            ObtenerGuid = Guid.NewGuid();
        }
        public Guid ObtenerGuid { get; set; }
    }
   
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }
    public class Serviciotransitorio
    {
        public Serviciotransitorio()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }
}
