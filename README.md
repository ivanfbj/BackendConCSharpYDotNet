# Curso de Fundamentos de Entity Framework

Descubre Entity Framework, un ORM moderno diseñado para .Net con un proyecto para sumar a tu portafolio. Realiza la conexión a una base de datos y crea los modelos utilizando Fluent API.

- Crea un proyecto .NET con Entity Framework.
- Utiliza Fluent API para especificar la configuración de los modelos.
- Conoce qué son las migraciones y agrega datos semilla al proyecto.
- Aprende los elementos de un CRUD para consumir datos con - Entity Framework

## Clase 1 - Bienvenida y presentación

Se aprenderá desde cero como funciona este componente de .NET, que permite conectarnos a una base de datos.

- Se analizarán los conceptos que maneja Entity Framework para su funcionamiento.

- Se revisarán 2 formas en las que se pueden utilizar Entity Framework, ya sea con atributos o Fluent API.

Se crearán 2 módelos: 1 de categoria y 1 de tareas, ambos están relacionados para poder análizar como Entity Framework crea las relaciones entre diferentes tablas

Luego esta configuración se conectará a una base de datos real y por ultimo se aprenderá como realizar las diferentes acciones de crea, actualizar y eliminar utilizando Entity Framework.

## Clase 2 - Prerrequisitos

- Conocimientos y experiencia en C#.
- Conocimientos de bases de datos.
- SDK de .NET.
- Visual Studio Code.
- Postman.
- SQL server / PostgreSQL.
- SQL management.

## Clase 3 - Conexión a base de datos

**Arquitectura básica**:

![Arquitectura básica](images/Arquitectura_basica.png)

Entity Framework se encarga de simplificar como construimos el Backend para podernos conectar a la base de datos.

**Tipos de conexión**:

- ODBC
- OLEDB
- SQL server
- Conexión Azure SQL

ODBC y OLEBD son drivers que se instalan directamente en el computador y por medio de una cadena se conexión se establece la conexión con la base de datos.

SQL server y Azure SQL son conexiones de Microsoft para la conexión.

En .NET tenemos un componente que permite hacer todas las conexiones a la base se datos, este componente se llama "**ADO.NET**" es un conjunto de librerías para acceder a bases de datos y servicios de datos.

**Funcionamiento de ADO.NET**:

![imagén de Funcionamiento de ADO.NET](images/funcionamiento_ado_dot_net.png)

## Clase 4 - ¿Qué es un ORM en programación?

 _**Object**-Relational Mapping_: Es una herramienta que realiza un mapeo que nos permite transformar los objetos de la base de datos como tablas y esquemas a clases con atributos en código de programación para poder manipular la información de una forma más fácil sin requerir de SQL.

Se apoya en objetos y clases para realizar la representación del concepto a utilizar.

**Desafíos en la conexión a una base de datos**:

- Mantenimiento del esquema.
- Creación de consultas usando SQL.
- Transformación de datos para ser usados en el backend.
- Garantizar la seguridad al manipular datos.

**ORM**:

Modelado de bases de datos relacional usando programación orientada a objetos.

Reemplaza a SQL como lenguaje de consultas utilizando funcionaes.

![imagen ORM](images/ORM.png)

**ORM populares**:

- Hibernate (Java)
- Dapper (.NET)
- NHibernate (.NET)
- Django ORM (Python)

## Clase 5 - Introducción a Entity Framework

- ORM de código abierto para .NET.
- Utiliza ADO.NET para facilitar la conexión a bases de datos y la manipulación de datos.

EF es compatible con: SQL Server, Azure SQL
Database, SQLite, Azure Cosmos DB, MySQL,
PostgreSQL, y otras bases de datos utilizando un API
plugin.

Entity Framework VS Entity Framework Core

Así como a ido evolucionando .NET también a ido evolucionando el Entity Framework.

**Ventajas  de EF:**

- Mejora la velocidad de desarrollo.
- Permite manejar un solo repositorio para backend y base de datos.
- Mejora la seguridad.
- Permite programar de manera más amigable y fácil.
- Nos permite controlar el historial de cambios de la base de datos de manera muy sencilla.

## Clase 6 - Creación de proyecto .NET con Entity Framework

**Proyecto .NET usando Minimal API**:

**Modelo - Tarea**:

- TareaId
- CategoriaId
- Titulo
- Descripcion
- Prioridad
- Fecha_Creacion

**Modelo - Categoria**:

- CategoriaId
- Nombre
- Descripcion

El proyecto se crea con el comando `dotnet new web`, luego es necesario realizar la instalación del paquete de `Microsoft.EntityFrameworkCore` que se encuentra en [nuget.org](https://www.nuget.org/), se utilizará el comando del .NET CLIENT

```Bash
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.4
```

Se debe buscar la versión acordé con el SDK que se esté trabajando en el proyecto y que no sea una version "preview".

El paquete `Microsoft.EntityFrameworkCore.InMemory` ayudará a crear una base de datos en memoria y poder probar el modelo que se está creando en .NET.

```Bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 7.0.4
```

El paquete `Microsoft.EntityFrameworkCore.SqlServer` nos permitirá conectarnos al motor de base de datos SQL server.

```Bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.4
```

## Clase 7 - Creación de modelos

A nivel de código se crean 2 modelos: `Categoria.cs` y `Tarea.cs`,  con sus respectivos atributos.

Los atributos "virtual" que se crearon en ambos modelos permite que en el momentos de realizar una consulta de cualquiera de los dos modelos, poder traer y asociar los datos correspondientes a la categoria que hace referencia, por ejemplo:

Si dentro de la consulta que se va a realizar se quiere traer información de una Tarea puedo saber que Categoria tiene asociada utilizando el atributo "virtual" de esta manera mostrar el nombre y la descripción de la Categoria.

En el caso contrario puedo utilizar la propiedad "virtual" de la clase Categoria para traer todas las Tareas que están asociadas a la categoria que estoy consultando.

Los atributos "virtual" me permite hacer la relación entre los diferente modelos que se tienen.

Estos modelos se convertirán en tablas dentro de la base de datos y cada uno de los atributos que tienen los modelos, serán las columnas que se crearán.

## Clase 8 - Configuración de Entity Framework

**Contexto**: Es donde van a ir todas las relaciones de los modelos que nosotros tenemos para poder transformarlo en colecciones que van a representarse dentro de la base de datos.

> Microsoft nos ofrece más información sobre esta clase en el siguiente enlace : [Trabajar con DbContext](https://docs.microsoft.com/es-es/ef/ef6/fundamentals/working-with-dbcontext)

**DBSet**: Es un set o una asignación de datos del modelo que nosotros hemos creado previamente, básicamente esto va a representar lo que sería una tabla dentro del contexto de entity framework.

> Un DbSet representa la colección de todas las entidades en el contexto, o que se puede consultar desde la base de datos, de un tipo determinado. Los objetos DbSet se crean a partir de DbContext mediante el método DbContext. set. Microsoft nos ofrece más información sobre esta clase en el siguiente enlace: [DbSet\<TEntity\> Clase](https://docs.microsoft.com/es-es/dotnet/api/system.data.entity.dbset-1?view=entity-framework-6.2.0)

A nivel de código se crea la clase `TareasContext.cs` que tiene la configuración genera de Entity Framework para tome los modelos como si fueran tablas en la base de datos.

