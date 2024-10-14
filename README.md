# Proyecto BlazorRecursivaProyectApp

Este es un proyecto Blazor Server llamado **BlazorRecursivaProyectApp** que consulta un API de horóscopos, guarda los datos en una base de datos SQLite, muestra el signo zodiacal más consultado. Este archivo README incluye las instrucciones de compilación y uso del proyecto.

## Requisitos previos

Antes de comenzar, asegúrate de tener instalados los siguientes programas:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) con las extensiones de C#.
- [SQLite](https://www.sqlite.org/download.html)
- [DBeaver](https://dbeaver.io/download/) (opcional, para ver y editar la base de datos).

## Instalación y configuración del proyecto

### 1. Clonar el repositorio (si es necesario)

```bash
git clone https://github.com/tu_usuario/blazorrecursivaprojectapp.git
```

### 2. Abrir el proyecto

Abre el proyecto en Visual Studio o Visual Studio Code.

### 3. Restaurar paquetes NuGet

Restaurar los paquetes NuGet es necesario para instalar las dependencias del proyecto. Desde el **Package Manager Console** o **CLI**, ejecuta el siguiente comando:

```bash
dotnet restore
```
### 4. Conexión a la base de datos

El proyecto utiliza el archivo Horoscopo.db como base de datos. Conectece utilizando su gestor de base de datos a esta para visualizar la informacion almacenada.

### 5. Ejecutar el proyecto

Para iniciar la aplicación, usa el siguiente comando en la terminal:

```bash
dotnet run
```

## Instrucciones de uso

1. **Pantalla de Inicio**: 
   - Al iniciar la aplicación, se mostrará la pantalla principal con una imagen y un botón de **INGRESAR**.
   - Haz clic en **INGRESAR** para comenzar.
   - Si ya realizo una consulta con anterioriodad, podra verificar el boton **ESTADISTICAS**
2. **Seleccion de Género**
   - Seleccione un género y de click al boton **CONTINUAR** 
3. **Formulario de Datos**: 
   - El usuario deberá completar un formulario con los siguientes campos:
     - **Nombre**: Ingresar el nombre.
     - **Email**: Ingresar una dirección de correo válida.
     - **Fecha de Nacimiento**: Ingresar la fecha de nacimiento usando el selector de fecha o escribiendo la fecha en formato `YYYY-MM-DD`.
   - Después de completar todos los campos, el botón **CONTINUAR** estará habilitado.

4. **Consulta del Horóscopo**: 
   - La aplicación enviará los datos del formulario a una API de horóscopo que calculará tu signo zodiacal y devolverá el horóscopo para el día actual.
   - En la siguiente pantalla se mostrará el horóscopo junto con un mensaje de bienvenida personalizado y la cantidad de días restantes para tu cumpleaños.

5. **Estadísticas**: 
   - Una vez se haya realizado al menos una consulta, aparecerá un botón de **ESTADISTICAS** en la pantalla de inicio.
   - Al hacer clic en el botón de **ESTADISTICAS**, se mostrará el signo zodiacal más consultado y un historial de todas las consultas anteriores. Si hay dos o mas signos que fueron consultados igual cantidad de veces se mostraran todos.

## Tecnologías Utilizadas

- **Blazor Server**: Utilizado para construir la interfaz de usuario interactiva y la lógica de la aplicación.
- **Entity Framework Core**: Utilizado para la comunicación con la base de datos SQLite y el manejo de consultas y persistencia de datos.
- **SQLite**: Base de datos utilizada para almacenar el historial de consultas de los usuarios.
- **ASP.NET Core**: Plataforma de desarrollo utilizada para crear la API del lado del servidor y las funcionalidades de la aplicación.
- **C#**: Lenguaje de programación principal utilizado en toda la lógica de la aplicación.
- **HTML5 y CSS3**: Para la maquetación y estilos de la aplicación, incluyendo componentes responsivos y diseño adaptable.
- **JSON**: Formato utilizado para enviar y recibir datos a través de la API de horóscopo.
- **NuGet**: Gestión de paquetes utilizada para instalar y administrar dependencias como `Microsoft.EntityFrameworkCore.Sqlite` y `Microsoft.EntityFrameworkCore.Tools`.

