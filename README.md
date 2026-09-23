# Eduardo Araneda · Portafolio

**[Visitar el portafolio](https://eduardoaraneda.github.io/Portafolio/)**

Presentación profesional con proyectos, tecnologías, experiencia en sistemas empresariales e integraciones y datos de contacto.

## Sitio publicado en GitHub Pages

La página pública se encuentra en **`index.html`**, en la raíz. Es un sitio estático con HTML5 y CSS responsive: incluye navegación por secciones, tarjetas de proyectos, habilidades y trayectoria profesional.

Para actualizar la web publicada, edita `index.html` y publica el cambio en `main`. GitHub Pages realiza el despliegue. Puedes abrir el archivo localmente en el navegador para revisar cambios. El contacto utiliza un enlace de correo; no requiere un servidor SMTP.

## Proyecto ASP.NET Core incluido

El repositorio también conserva una versión MVC con C#, .NET 10, vistas Razor y un servicio de correo. **GitHub Pages no ejecuta esta aplicación .NET**; las vistas Razor no son la fuente de la página pública.

Para ejecutar la versión MVC, instala el SDK de .NET 10 y, desde la raíz:

```powershell
dotnet restore Portafolio.csproj
dotnet build Portafolio.csproj
dotnet run --project Portafolio.csproj
```

Abre la URL que indique la terminal. Para su formulario de contacto, configura por separado `CONFIGURACIONES_EMAIL:EMAIL`, `CONFIGURACIONES_EMAIL:CONTRASEÑA`, `CONFIGURACIONES_EMAIL:HOST` y `CONFIGURACIONES_EMAIL:PUERTO` con tu servicio SMTP.

## Proyecto destacado

[Comercial Manufacturera](https://github.com/eduardoaraneda/comercial-manufacturera): cotizaciones con reserva de stock, ventas e inventario por bodega. [Demostración](https://portafolio.somee.com), con acceso autorizado.

## Configuración y alcance

Usa una base de desarrollo y credenciales propias. Configura secretos mediante variables de entorno o User Secrets; no los incluyas en commits. La compilación no comprueba la disponibilidad de bases de datos, SMTP o APIs externas.

## Autor

[Eduardo Araneda](https://github.com/eduardoaraneda) · [Portafolio](https://eduardoaraneda.github.io/Portafolio/)
