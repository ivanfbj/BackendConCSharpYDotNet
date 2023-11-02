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

## Clase 6 - Code Smells

Transmite la sensación de que algo en el código está mal.

Al realizar el análisis sobre código y algo que notamos nos está transmitiendo la sensación de que algo está mal, de que algo no está correcto, de que algo no está bien hecho o de que algo se puede mejorar.

A nivel de código para poder quitar los "Números mágicos" existen 2 posibles soluciones, una es utilizar constantes y colocarles un nombre descriptivo sobre que representa o para que se utiliza, la otra solucón es utilizar las enumeraciones como se visualiza en el código.

**Comentarios:**

Sensación de que algo va mal con el código al percibir algunos indicadores de posibles errores. A veces estos errores pueden ser indicaciones de mala calidad del código, pero, esto que a simple vista se ve como “mal, feo, o raro”, en muchas ocasiones puede ser causante de problemas más profundos de funcionamiento en el código del programa o aplicación, lo que conllevaría una refactorización o incluso una reescritura del código para lograr un código limpio y su mejor funcionamiento.

**Algunos ejemplos de code smell:**

- Variables, métodos o clases con nombres poco descriptivos.

- Métodos y clases de muchísimas líneas que se vuelven difíciles o tediosos de entender. Esto es un indicativo de que las funcionalidades que contienen se pueden separar en pequeñas partes y así poder dividir las responsabilidades en clases y metodos mas pequeños y entendibles.

- Métodos o funciones que reciben demasiados parámetros, lo que indica que hay mucha lógica dentro de esa función.

- Utilización de “Números mágicos” o “quemados”, esto se refiere a números fijos que utilizamos dentro de la lógica de nuestro código y que puede causar que a primera vista no se entienda cuál es su función dentro del mismo y se requiera de más tiempo para comprender lo que hacen.

**Tipos de code smell:**

Para considerar los diferentes code smells, hay que distinguir entre los niveles de abstracción del código:

1. Code smells de forma general.
2. Code smells a nivel de función.
3. Code smells a nivel de clase.
4. Code smells a nivel de la aplicación

Para complementar la información sobre los tipos de code smell les recomiendo la lectura de este artículo: [Code smell explicado de forma sencilla](https://www.ionos.es/digitalguide/paginas-web/desarrollo-web/code-smell)

## Clase 7 - Principio DRY

Significa: **"Don't Repeat Yourself"**

Invita que no estemos escribiendo las mismas pociones de código todo el tiempo en diferentes parte, la idea es poder reutilizar las rutinas de código y máximizar la forma de distribuir el código.

Copiar y pegar código no está mal, es algo común, solamente que lo importan es entender el funcionamiento de ese código y estructurarlo para que encaje en nuestro proyecto y se pueda reutilizar en diferentes partes o se pueda combinar con el código existente.

Hay 2 formas en las que normalmente se repite el código:

1. El código se repite exactamente igual: la solución es crear una función con dicho código.

2. Se repiten pequeñas rutinas de código: Se busca la manera de poder crear una función o un método en común que podamos definir diferentes comportamientos utilizando parámetros.

A nivel del código se encuentra que el código que muestra la lista de tareas se repite 2 veces, por lo cual es posible migrarlo a un método y cambiar los pedazos de código por dicho método.

**Comentarios:**

Principio DRY

DRY: Don’t Repeat Yourself (No te repitas) .

El objetivo de este principio es evitar la duplicación de partes de código en nuestro código. Andy Hunt y Dave Thomas formularon en su libro «The Pragmatic Programmer: From Journeyman to Master» el siguiente principio:

> «Every piece of knowledge must have a single, unambiguous, authoritative representation within a system»

Que en español se traduciría como:

> «Cada pieza de conocimiento debe tener una única representación autorizada, sin ambigüedades, dentro de un sistema».

El código duplicado no siempre es fácil de reconocer o para poder eliminarlo puede que resulte más compleja la solución. una regla de oro en el refactoring es la Regla de tres: repetir una vez el mismo código puede ser aceptable, pero la tercera vez que utilizamos el mismo código, es señal inequívoca de que hay que refactorizar y solucionar la duplicación.
