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

ODBC y OLEBD son dirves que se instalan directamente en el computador y por medio de una cadena se conexión se establece la conexión con la base de datos.

SQL server y Azure SQL son conexiones de Microsoft para la conexión.

En .NET tenemos un componente que permite hacer todas las conexiones a la base se datos, este componente se llama "**ADO.NET**" es un conjunto de librerías para acceder a bases de datos y servicios de datos.

**Funcionamiento de ADO.NET**:

![imagén de Funcionamiento de ADO.NET](images/funcionamiento_ado_dot_net.png)

