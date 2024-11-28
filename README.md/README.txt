# Proyecto de Programación - Sistemas de Alarmas

Este proyecto incluye un sistema para gestionar alarmas en **Windows Forms**, utilizando una arquitectura en tres capas (BLL, DAL, ENTITY, y VISTA).

## Contenido
- **Backup de la base de datos**: El respaldo está disponible en la carpeta `backup`. Puedes descargarlo directamente [aquí](backup/mi-base-de-datos.bak).

## Cómo usar el proyecto
1. Clona este repositorio.
2. Restaura el backup de la base de datos en tu servidor SQL.
3. Abre y ejecuta el proyecto en Visual Studio.

- **Nota**: Si tienes problemas para visualizar correctamente la aplicación al ejecutarla, verifica la configuración de tu pantalla:
  1. Ve a **Configuración** en tu PC.
  2. Haz clic en **Sistema** y selecciona la opción **Pantalla**.
  3. En el apartado de **Escala y diseño**, ajusta la escala al **100%**.

## Tecnologías utilizadas
- **C#**: Windows Forms para el frontend.
- **SQL Server**: Base de datos.
- **Git**: Control de versiones.
- **GMap.NET**: Biblioteca utilizada para la integración de mapas.
- **GMap.NET.WindowsForms**: Implementación específica para aplicaciones Windows Forms.

## Bibliotecas necesarias
Este proyecto utiliza las siguientes bibliotecas externas, que deberás instalar antes de ejecutarlo:
- **GMap.NET**: [Repositorio oficial en GitHub](https://github.com/radioman/greatmaps).
- **GMap.NET.WindowsForms**: Puedes instalarla fácilmente desde NuGet, dando click derecho en la solución del proyecto, dirigiéndote administrar paquetes NuGet para la solución, busca la librería y la instalas.



