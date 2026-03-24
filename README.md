# \# Portafolio

# 

# Proyecto web ASP.NET Core con vistas Razor pensado como portafolio personal. Incluye páginas de presentación, listado de proyectos, habilidades y un formulario de contacto.

# 

# \## Requisitos

# 

# \- .NET 10 SDK

# \- Visual Studio 2022/2026 o VS Code con extensiones C#

# 

# \## Ejecutar localmente

# 

# 1\. Restaurar paquetes:

# 

# ```powershell

# dotnet restore

# ```

# 

# 2\. Compilar:

# 

# ```powershell

# dotnet build

# ```

# 

# 3\. Ejecutar la aplicación:

# 

# ```powershell

# dotnet run --project Portafolio.csproj

# ```

# 

# Abrir la URL indicada en la salida (por ejemplo `https://localhost:5001`).

# 

# También puede abrir la solución en Visual Studio y ejecutar con depuración (F5).

# 

# \## Estructura principal

# 

# \- `Views/Home/` — Vistas principales: `Index`, `Proyectos`, `Contacto`, `Gracias` y parciales.

# \- `wwwroot/` — Archivos estáticos (CSS, JS, imágenes).

# \- `Controllers/` (si aplica) — Lógica de controladores.

# 

# \## Personalización

# 

# \- Editar las vistas en `Views/Home/` para cambiar contenidos.

# \- Actualizar imágenes en `wwwroot/images`.

# \- Añadir o modificar proyectos en `\_ListadoProyectos.cshtml` o en la fuente de datos correspondiente.

# 

# \## Publicación

# 

# Publicar en Release y subir la carpeta `publish` al host:

# 

# ```powershell

# dotnet publish -c Release -o ./publish

# ```

# 

# Se puede desplegar en Azure App Service, IIS o en contenedor Docker.

# 

# \## Contribuciones

# 

# Pull requests y issues pequeñas para mejorar el contenido o accesibilidad son bienvenidas.

# 

# \## Licencia

# 

# Agregar un archivo `LICENSE` si desea establecer una licencia (por ejemplo MIT).

