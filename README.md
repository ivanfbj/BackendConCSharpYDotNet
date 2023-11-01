# Curso de Buenas Prácticas y Código Limpio en C\#

## Clase 1 - Presentación

Se aprenderá como mejorar el código, cómo escribir un mejor código en C# y seguir los mejores estandares que hay en la industria del software.

Se tomará de base un código existente y funcional pero que no tiene las mejores practicas dentro del código.

El reto será modificar el código para que cumpla con los mejores estandares de buenas practicas pero sin afectar la funcionalidad de la aplicación.

## Clase 2 - Prerrequisitos

- Conocimiento en C# y .NET
- Conocimiento de Git
- Visual Code o Visual Studio
- .NET 6 0 superior

## Clase 3 - Terminología: Buenas prácticas, refactoring, código limpio, deuda técnica

**Buenas Prácticas o Best practices:**

- Estándares comprobados y verificados.
- Resuelven desafíos de escenarios comunes.
- Brindan guías fáciles de aprender y comprender.
- Permiten tener una estructura similar para múltiples proyectos.

**Código Limpio o Clean Code:**

- Un código que sigue las buenas prácticas.
- Código fácil de entender y analizar.
- Código fácil de mantener.
- Código fácil de actualizar.
- Código fácil de escalar.
<br>

    **Cómo logramos código limpio**
    - Mantener bajo acoplamiento.
    - Utilizar sintaxis simple y moderna.
    - Evitar incorporar muchas librerías de terceros.
    - Distribución de responsabilidades.
    - Creación de componentes pequeños.

**Deuda técnica o technical debt:**

- Se refiere a los problemas técnicos que puede tener un software que son adquiridos durante la fase de desarrollo y que deben ser solucionados en el futuro.
- Puede estar presente en cualquier aspecto de una aplicación como: Seguridad, rendimiento, escalabilidad, etc...
- A veces puede resultar más costosa que el mismo desarrollo.

**Refactoring:**

- Proceso de cambios sobre un código para el mejoramiento en cualquier aspecto (rendimiento, seguridad, legibilidad, soporte, etc...)
- Lo más importante es hacer los cambios manteniendo la lógica de negocio sin afectaciones.
- Debe ser recurrente. (Por lo menos cada 6 meses, revisar versiones de libreria, mejorar las prácticas del código)
- Disminuye la deuda técnica a futuro.

## Clase 4 - Descarga y análisis del proyecto a trabajar

El código de ejemplo se encuentra en Github [curso-codigo-limpio-csharp](https://github.com/platzi/curso-codigo-limpio-csharp/tree/master) el código se puede clonar o descargar el .ZIP o también está en el archivo `Program.cs`.

En caso de trabajar con Visual Studio Code para compilar y ejecutar el código se requieren los siguientes comandos en la terminal:

Compilar: `dotnet build`
Ejecutar: `dotnet run`

## Clase 5 - Nombramiento

**Variables**: El nombre de la variable debe ser lo más descriptivo posible.

```C#
//Mal:
int b;

//Bien:
int daySinceModification;
```

**Método**: El nombre de los métodos debe ser lo más descriptivo posible, debe ser en forma de **PascalCase**

Tampoco se debe incluir números en el nombramiento del método.

```C#
//Mal:
public List<Users> getUsers();

//Bien:
public List<Users> GetActiveUsers();
```

**Clases**: El nombre de las clases debe ser lo más descriptivo posible. Se debe omitir la "Notación húngara" que consiste indicar el tipo de variable en el nombre en este caso "Class.." para indicar que es una clase.

Tampoco se debe incluir números en el nombramiento de la clase.

```C#
//Mal:
public class ClassUser2;

//Bien:
public class User;
```

A nivel de código se cambian los nombre de algunas variasbles y métodos para poder hacer el código un poco más legible.

