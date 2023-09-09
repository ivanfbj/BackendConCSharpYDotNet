# [Curso Básico de Programación con C#](https://platzi.com/cursos/csharp/)

C# es uno de los lenguajes de programación más utilizados para desarrollo web y videojuegos. Da tus primeros pasos en C#, junto al profesor Ricardo Celis, construyendo juegos virtuales mientras aprendes las siguientes habilidades:

- Utilizar ciclos y condicionales.
- Instalar y utilizar Visual Studio.
- Crear tus primeros programas.
- Conocer las aplicaciones del lenguaje.

## Clase 1 - ¿Qué necesitas para aprender C#?

Pensamiento lógico y programación básica.

## Clase 2 - ¿Por qué aprender C#?

Es un lenguaje comprensible, orientado a objetos, multiplataforma (linux, windows), tiene un soporte enorme, está constantemente en actualización.

**.NET**: es el entorno para desarrollar una gran cantidad de aplicaciones, desde aplicaciones de escritorio hasta aplicaciones web, móviles, video juegos (Unity). Proporciona un conjunto de herramientas y bibliotecas robustas que simplifican el proceso de desarrollo, lo que lo convierte en una opción popular entre los desarrolladores de software.

## Clase 3 - ¿Qué son los algoritmos?

Un algoritmo es un conjunto de instrucciones que resuelven un problema paso a paso y sin ambigüedades. Tendremos una serie de objetos o elementos en nuestros programas y tambien tendremos una logica una serie de pasos a seguir para que el software se comporte de la forma esperada. Esta logica o estos pasos a seguir es lo que se conoce como algoritmos.

Se denomina algoritmo a un grupo finito de operaciones organizadas de manera lógica y ordenada que permite solucionar un determinado problema. Se trata de una serie de instrucciones o reglas establecidas que, por medio de una sucesión de pasos, permiten arribar a un resultado o solución.

## Clase 4 - Instalando Visual Studio 2022

[Descargar Visual Studio 2022 - Community](https://visualstudio.microsoft.com/es/downloads/)

## Clase 5 - Aprendiendo a usar Visual Studio

Al abrir Visual Studio, se da en la opción de Crear un proyecto y se debe seleccionar la plantilla "Aplicación de consola" que en la parte inferior muestra C#.

Para este caso en la ventana donde el sistema pide el nombre del proyecto, ruta en donde se guardará la información, nombre de la solución y un checkbok para indicar si "Colocar la solución y el proyecto en el mismo directorio".

Nombre del proyecto: cursoBasicoDeProgramacionConCSharp
Nombre de la solución: BackendConCSharpYDotNet
NO: "Colocar la solución y el proyecto en el mismo directorio"

El proyecto nuevo de consola que se ha creado viene con un ejemplo de "Hello, World!", visual studio se encarga de compilar y realizar la ejecución del programa:

**Compilar**:

- **Definición**: Compilar es el proceso de traducir el código fuente escrito en un lenguaje de programación (en este caso, C#) a un lenguaje de máquina o código intermedio que la computadora pueda entender y ejecutar. El resultado de la compilación es un archivo ejecutable (por ejemplo, un archivo con extensión .exe en el caso de aplicaciones de escritorio C#) o un conjunto de archivos intermedios, dependiendo del tipo de aplicación que estés desarrollando.

- **Importancia**: La compilación es una etapa fundamental en el desarrollo de software, ya que garantiza que el código escrito se traduzca correctamente y esté listo para su ejecución. Durante el proceso de compilación, se realizan verificaciones de sintaxis y semántica para detectar errores en el código.

**RunTime**:

- **Definición**: RunTime (tiempo de ejecución en español) se refiere al período durante el cual un programa de software se ejecuta en una computadora. Es el momento en el que el código compilado se ejecuta y realiza las tareas para las cuales fue diseñado. Durante este tiempo, el programa interactúa con datos, realiza cálculos y ejecuta instrucciones según lo especificado en el código fuente.
- **Importancia**: El tiempo de ejecución es crucial porque es cuando los usuarios interactúan con la aplicación y esta produce resultados. Durante el tiempo de ejecución, se asignan recursos de hardware y se administran, como memoria y CPU, para que el programa funcione correctamente.

En resumen, la compilación es el proceso de traducir el código fuente a un formato ejecutable, mientras que RunTime es el período en el que el programa se ejecuta y realiza sus funciones. Ambos conceptos son fundamentales en el desarrollo de software con C# y otros lenguajes de programación.

## Clase 6 - Tipos de datos primitivos

| Tipo de dato | Espacio en memoria | Rango                    | Descripción                                              |
|--------------|--------------------|--------------------------------|----------------------------------------------------|
| int          | 4 bytes            | -2,147,483,648 a 2,147,483,647 | Representa números enteros de 32 bits              |
| bool         | 1 bit             | 0 a 1                          | Representa un valor booleano (verdadero o falso)   |
| float        | 4 bytes            | -3.402823e38 a 3.402823e38     | Representa números de punto flotante de precisión simple |
| double       | 8 bytes            | -1.79769313486232e308 a 1.79769313486232e308 | Representa números de punto flotante de precisión doble |
| char         | 2 bytes            | Un solo carácter       | Representa un solo carácter Unicode               |
| string       | 2 bytes por carácter           | Variable                 | Representa una secuencia de caracteres            |
| long         | 8 bytes            | -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807 | Representa números enteros de 64 bits     |
| uint         | 4 bytes            | 0 a 4,294,967,295        | Representa números enteros sin signo de 32 bits    |

## Clase 7 - Variables

Programa en el archivo `Program.cs` contiene un programa sencillo de calcular el área de un rectángulo con lado A y lado B, donde se declaran los tipos de datos en las variables.

## Clase 8 - La palabra reservada var

El tipo de variable "var" se utiliza para declarara de forma implicita variables, por lo cuál se deja que C# infiera el tipo de variable que se requiera. La variables de forma implicita se deben de inicializarla.

## Clase 9 - Uso de constantes

La inicialización de una variable tipo "var" y especificar si va a ser double o float se puede realizar con la letra d o f, ejemplo:

```C#
var variableDouble = 0d;
var variableFloat = 0f;
```

La convención de una constantes en C# suele ser en PascalCase:

```C#
const double EstaVariablesEsConstanteTipoDouble = 0d;
```

Las variables de tipo constante, en programación, son valores que no pueden ser modificados después de haber sido asignados durante la ejecución del programa. Una vez que se les asigna un valor, ese valor no puede ser cambiado posteriormente. Esto significa que las variables de tipo constante son inmutables.

## Clase 10 - Operadores aritméticos

El operador `++` es equivalente a sumar 1 a la variable.  
El operador `--` es equivalente a restar 1 a la variable.  

Ejemplo:

```C#
int numero1 = 5;
int numero2 = 15;

numero1++; //Resultado: 6
numero2--; //Resultado: 14
```

El operador `*` permite multiplicar.  
El operador `/` permite dividir.  
El `%` es el operador de residuo, devuelve el restante de una división.  

## Clase 11 - Operadores lógicos

Los operadores lógicos en C# son utilizados para comparar y combinar valores booleanos. Los operadores lógicos disponibles en C# incluyen:

`&&` (and): Devuelve verdadero si ambos operandos son verdaderos.
`||` (or): Devuelve verdadero si al menos uno de los operandos es verdadero.
`!` (not): Invierte el valor booleano del operando.
`^` (xor): Devuelve verdadero los valores booleanos son diferentes. Compara si los valores son diferentes
Ejemplo:

```C#
bool a = true;
bool b = false;
bool c = (a && b); // c es false
bool d = (a || b); // d es true
bool e = !b; // e es true
bool f = (a ^ b); // f es true porque a y b son diferentes.
```

## Clase 12 - Operadores relacionales

Los operadores relacionales en C# se utilizan para comparar valores y determinar si una relación es verdadera o falsa. Los operadores relacionales disponibles en C# incluyen:

`==` (igual a): Devuelve verdadero si los operandos son iguales.
`!=` (no igual a): Devuelve verdadero si los operandos son diferentes.
`>` (mayor que): Devuelve verdadero si el operando de la izquierda es mayor que el de la derecha.
`<` (menor que): Devuelve verdadero si el operando de la izquierda es menor que el de la derecha.
`>=` (mayor o igual que): Devuelve verdadero si el operando de la izquierda es mayor o igual que el de la derecha.
`<=` (menor o igual que): Devuelve verdadero si el operando de la izquierda es menor o igual que el de la derecha.

```C#
int x = 5;
int y = 10;
bool a = (x == y); // a es false
bool b = (x != y); // b es true
bool c = (x > y); // c es false
bool d = (x < y); // d es true
bool e = (x >= y); // e es false
bool f = (x <= y); // f es true
```

## Clase 13 - Strings en C\#

Una cadena es un objeto de tipo `String` cuyo valor es texto. Internamente, el texto se almacena como una colección secuencial de solo lectura de objetos `Char`. No hay ningún carácter que finalice en NULL al final de una cadena de C#; por lo tanto, la cadena de C# puede contener cualquier número de caracteres nulos insertados ("\0"). La propiedad `Length` de una cadena representa el número de objetos Char que contiene, no el número de caracteres Unicode.

El carácter `$` identifica un literal de cadena como una cadena interpolada. Una cadena interpolada es un literal de cadena que puede contener expresiones de interpolación. Cuando una cadena interpolada se resuelve en una cadena de resultado, los elementos con expresiones de interpolación se reemplazan por las representaciones de cadena de los resultados de la expresión.

La interpolación de cadenas proporciona una sintaxis más legible y conveniente de dar formato a las cadenas. Es más fácil de leer que el formato compuesto de cadenas. En este ejemplo se usan ambas características para producir el mismo resultado:

```C#
var name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
// Both calls produce the same output that is similar to:
// Hello, Mark! Today is Wednesday, it's 19:40 now.
```

La barra diagonal inversa `(\)` en una expresión regular que indica que el carácter que va detrás de ella es un carácter especial. Por ejemplo, `\b` es un delimitador que indica que una coincidencia de expresión regular debería comenzar en un límite de palabras, `\t` representa un carácter de tabulación, `\n` representa un salto de línea.

Para más detalles del carácter de escape ingresar al enlace [Escapes de carácter en expresiones regulares](https://learn.microsoft.com/es-es/dotnet/standard/base-types/character-escapes-in-regular-expressions).

```C#
string escape = "Primera fila y luego salto \n segunda fila generada por el carácter de escape.";
Console.WriteLine(escape);

//Salida
/*
Primera fila y luego salto
 segunda fila generada por el carácter de escape.
*/

```
