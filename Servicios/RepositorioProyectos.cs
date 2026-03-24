namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<Models.Proyecto> ObtenerProyectos()
        {
            return new List<Models.Proyecto>()
            {
                new Models.Proyecto()
                {
                    Titulo = "Proyecto 1",
                    Descripcion = "ERP de Ventas The Line",
                    link = "https://www.theline.cl",
                    UrlImagen = "/imagenes/TL.png"
                },
                 new Models.Proyecto()
                {
                    Titulo = "Proyecto 2",
                    Descripcion = "ERP de Ventas Tecnobuy",
                    link = "https://www.Tecnobuy.cl",
                    UrlImagen = "/imagenes/TB.png"
                },
                   new Models.Proyecto()
                {
                    Titulo = "Proyecto 3",
                    Descripcion = "ERP de Ventas Andpac",
                    link = "https://www.Andpac.cl",
                    UrlImagen = "/imagenes/andpac.png"
                },
            };
        }
    }
}
