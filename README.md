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
