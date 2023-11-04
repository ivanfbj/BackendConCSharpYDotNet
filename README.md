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

## Clase 8 - Principio KISS

Significa: **Keep It Simple Stupid**
**Keep It Short and Simple**(forma elegante).

Se debe en lo posible simplificar el código que se está realizando, sin crear demasiados elementos, demasiados componentes, sin desglozar demasiado el código cuando esto no es necesario.

La sobre arquitectura es cuando diseñamos la aplicación demasiado grande o demasiado compleja para dar solución a algo que es demasiado simple.

A nivel de código se modifica un **if** anidados y se deja un solo **if** para simplificar el código.

El **for** que se encarga de mostrar los datos se puede simplificar con el método ForEach de la lista y una expresión lambda.

```C#
int indexTask = 1;
taskList.ForEach(element => Console.WriteLine((indexTask++) + ". " + element));
```

**Comentarios:**

KISS: es un acrónimo de Keep It Simple Stupid o Keep It Short and Simple y a rasgos generales se puede traducir como Mantenlo simple!.

Este principio establece que la mayoría de sistemas funcionan mejor si se mantienen simples o sencillos a diferencia de aquellos que se hacen complejos de manera innecesaria. Es decir, que desde el incio del proyecto la sencillez tiene que ser una meta en el desarrollo y que la complejidad innecesaria debe ser eliminada cada vez que sea detectada. Muchas veces esta complejidad ocurre cuando se diseñan grandes soluciones para objetivos simples.

> Tratemos de utilizar la mejor solución dependiendo de la complejidad de lo que estemos trabajando. Cuando algo es muy complejo o muy grande, es recomendable buscar soluciones más complejas o avanzadas que se ajusten, pero si algo es más simple, pequeño o sencillo, lo ideal es darle una solución acorde a sus características.

Es bueno tener presente que:

> Si ya no comprendes tu propio código después de un breve período de tiempo, las campanas de alarma deberían sonar. Porque cuanto más complicado es o se presenta, más difícil es para todos los involucrados trabajar con él.

Algunos ejemplos de complejidad innecesaria son:

- Incluir bibliotecas enormes en el proyecto cuando solo se necesitan un par de funciones de ellas.
- Abstracción excesiva en el código.
- Funciones que resultan enormes por por la lógica que contienen.
- Anidación de condicionales que solo cumplen una función.

## Clase 9 - Usando try catch

Try catch es para excepciones.

- Son escenarios excepcionales o inusuales en el código.
- Se implementa donde se desee devolver un valor específico después de realizar el control.
- El rendimiento se ve afectado al capturar la excepción.

A nivel de código se implementa un "Console.WriteLine" en el catch del método "ShowMenuRemove()", ya que si se elimina una tarea por fuera del rango de la lista se generaría un error.

Adicionalmente lo que se hace es implementar una condición para controlar el error antes de que suceda, esto con el objetivo de que el try catch se encargue de los errores que son realmente inesperados en el código.

## Clase 10 - Evolución de C\#

Desde el 2017 C# a ido evolucionando con mayor rápidez, en la que apróximadamente cada año saca una versión nueva incluyendo una versión nueva de .NET.

**C# 6 - Auto Property Initializer:**

Esta mejora permite asignar un valor por defecto a una propiedad dentro de una clase

```C#
public string MyVar { get; set; } = "Hello World" ;
```

**C# 6 - String Interpolation:**

Permite utilizar el signo pesos y las llaves para concatenar una variable dentro de un string de una forma más ordenada y sencilla.

```C#
string MyVar = "Hello World";
Console.WriteLine($"The message is: {MyVar}");
```

**C# 6 - Expression - Bodied Function:**

Se pueden crear funciones de una forma más rápida utilizando el operador flecha, cuando la función tiene una acción simple.

```C#
public int Sum2Numbers( int x, int y) => (x + y);
```

**C# 6 - null conditional operator**

El operador null para condicionales nos permite verificar, si una porpiedad es nula o no al momento de realizar una evaluación.

Esto nos ahorraría un **IF**

```C#
DateTime? datetime = new DateTime( ) ;

// using ? asking i f the value is null
var Year0fDate = datetime?.Year;

Console.WriteLine(Year0fDate) ;

var Year0fDateConditional = datetime?.Year ?? @ •
```

**C# 7 - Local functions:**

Es una mejora que permite crear funciones dentro de métodos, para estructurar un poco mejor el código.

```C#
static void Main(string[] args)
{
    int Sum(int x, int y)
    {
        return x + y;
    }
    Console.WreiteLine(Sum(10,20));
    Console.ReadKey();
}
```

**C# 7 - Digital separator:**

Nos permite utilizar el guión bajo para separar los caracteres de un número y pueda facilitar la visualización.

```C#
public const long BillionsAndBillions = 100_000_000_000;
```

**C# 7 - Tuples:**

La tuplas permite retornar una combinación de diferentes valores y de diferentes tipos al momento que se requiera

```C#
var named = (first: "one", second: "two" ) ;

//method returning a tuple
(bool bresult, double dcalculation) = Tuples.CalculationTuple() ;
```

**C# 8 - Switch as expression:**

Es una forma más sencilla y compacta de poder utilizar la expresión del Switch, permitiendo recibir y devolver el resultado cuando es un solo valor.

```C#
//switch as expression
int intValueForSwitch = 0;
var state = (intValueForSwitch) switch
{
    (0) => "Zero" ,
    (1) => "One" ,
    (2) => "Two" ,
    _ => "NO valid number"
};
```

**C# 9 - Top - level statement:**

Nos permite eliminar la estructura generica que se manejaba en C\#, donde se requieria un namespace y una clase para poder ejecutar el código.

Ahora solamente se requiere el using System y comenzar a usar el código directamente

```C#

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}

//Ahora con C# 9 queda de la siguiente manera

using System;

Console.WriteLine("Hello World");

```

**C# 10 - Global using:**

Noa ayuda a minimizar el código ya que se detectan automaticamente los using que hacen parte del Core de .NET, el código detecta automaticamente que estamos utilizando la consola y no se requiere el `using System;`

```C#
Console.WriteLine("Hello World");
```

Enlaces de interes:

[Novedades de C# 12](https://learn.microsoft.com/es-es/dotnet/csharp/whats-new/csharp-12)
[Novedades de C# 11](https://learn.microsoft.com/es-es/dotnet/csharp/whats-new/csharp-11)
[Novedades de C# 11](https://learn.microsoft.com/es-es/dotnet/csharp/whats-new/csharp-10)

## Clase 11 - Interpolación de cadenas, inicializador de propiedades y operador condicional null

A nivel de código se implementan algunas de las mejoras vistas en la Clase 10.

## Clase 12 - Implementando minimalismo

Se modifica el archivo `cursoDeBuenasPracticasYCodigoLimpioEnCSharp.csproj` para realizar una actualización de la versión de .NET que se está utilizando, en el video de cambio la versión del Framework de `netcoreapp3.1` a `net6.0` y se agregó la configuración de los using implicitos `<ImplicitUsings>enable</ImplicitUsings>`.

Implementando estas actualizaciones el sistema en el archivo `Progrma.cs` nos permite eliminar los `using` del sistema y el namespace se puede eliminar y quitar las llaves que encierran el resto de código.

Adicionalmente se puede eliminar la clase `internal class Program` incluyendo la llave de apertura y cierre, también se puede eliminar el método `static void Main(string[] args)`.

De los métodos creados se puede quitar el `public static`.

## Clase 13 - Uso de comentarios

Un mal comentario sería que indique los mismo que ya dice la clase, por ejemplo:

```C#
// The User class
public class User{
    //......
}
```

Esto hace que el comentario aumente la cantidad de lineas de código y ensucie la lectura del código, además de ser redundante.

En general un código siempre debe ser muy fácil de entender, cada nombre que se utilice para las clases, métodos, variables y componentes del sistema debe ser lo suficientemente descriptivo para que no sea necesario agregar comentarios.

En general no se deberia de comentar malos código sino que se deberia de reescribir.

> Don't comment bad code - Rewrite it. - Brian Kernighan

**Recomendaciones para comentar**:

- No abuses de los comentarios.
- Si los comentarios son obvios, no los pongas.
- Escribe código fácil de entender como filosofía.
- No comentes la trazabilidad de cambios. (Git se encarga de la trazabilidad)
- Mantén los comentarios cortos y claros.
- No dejes código comentado.

A nivel de código se mejoran los comentarios.
