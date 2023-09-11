# Curso de Programación Orientada a Objetos con C\#

## Clase 1 - Fundamentos de Programación Orientada a Objetos con C\#

Curso base para adquirir los conocimientos para desarrollar aplicaciones en C\# y .NET.  

Conceptos importantes del paradigma de POO:

1. **Clases y Objetos**
    - Son los elementos base para programar en la porgramación orientas a objetos, las clases nos permiten definir propiedades y comportamientos como una plantilla que podemos reutilizar para poder crear nuestros objetos.
2. **Encapsulamiento**
    - Se refiere a ocultar los valores reales o el detalle de los valores que tienen las propiedades o las caracteristica de nuestras clases.
3. **Herencia**
    - Es la forma en que se puede reutilizar código en la programación orientada a objetos, nos permite pasar las propiedades y lo métodos que tenemos en una clase a otra.
4. **Polimorfismo**
    - Podemos definir diferentes comportamientos para el mismo método, aceptando los mismos valores, los mismo parámetros, retornando el mismo tipo de dato pero definiendo diferente comportamiento en diferentes clases.
5. **Abstracción**
    - Es un concepto que nos permite omitir los detalles de las implementaciónes que estamos haciendo en nuestra clase, de esta manera podemos crear elementos mucho más genericos que nos permiten reutilizar nuestro código para multiples escenarios.

## Clase 2 - Prerequisitos

- Conocimientos de C# y .NET
- .NET 7 0 superior.
- Visual Studio Code o Visual Studio.

## Clase 3 - ¿Que es la programación orientada a objetos (POO)?

**¿Qué son los paradigma de la programación?**

- Formas o estilos en los que podemos programar y estructurar nuestro código.

**Paradigmas importantes:**

- Programación funcional
- Programación estructurada
- Programación reactiva
- Programación orientada a aspectos
- Programación orientada a objetos

`C#` es multi-paradigma, el cual nos permite usar multiples estilos de programación. Lo común en `C#` es mezclar varios paradigmas al escribir el código.

El paradigma de la programación orientada a objetos suele ser uno de los más importantes, la mayoria de componentes o librerias de `C#` se basan en este paradigmna.

**Conceptos de POO - OOP:**

- Paradigma de la programación.
- El objetivo es extraer elementos de la realidad a los algoritmos en nuestro código.
- Basado en clases y objetos.

Las clases serían las plantillas o estructuras que se van a reutilizar para poder crear los objetos.

## Clase 4 - Creando tu primera clase y objeto

Se crea un proyecto con Visual Studio, el proyecto es de tipo "Aplicación de consola" u se trabaja con el framework .NET 7.0.

Las caracteristicas o variables que se agregan a una clase se les conocen como propiedades.

Se crea un ejemplo diferente al del vídeo. Los temas tratados son:

1. Crear una clase llamada "Computador".
2. La clase contiene las propiedades que harán referencia a las caracteristicas de dicha clase.
3. Las propiedades deben tener un modificador de acceso, en este ejemplo están de forma pública.
4. Una vez creada la clase se puede instanciar con la propiedad "new" la cual permite crear un objeto de dicha clase.
5. Al crear el objeto ya se podrá asignar valores a las propiedades.

Ejemplo:

```C#
// Instanciar una clase nos permite crear un objeto con las propiedades de dicha clase, para esto se utiliza la propiedad "new".
Computador ComputadorAcerNitro5 = new Computador();
Computador ComputadorHpVictus = new Computador();

ComputadorAcerNitro5.Marca = "Acer";
ComputadorHpVictus.Marca = "HP";  
class Computador
{
    public string Marca;
}
```

____

**Modificadores de acceso:**

- **public:** Puede obtener acceso al tipo o miembro cualquier otro código del mismo ensamblado o de otro ensamblado que haga referencia a éste. El nivel de accesibilidad de los miembros públicos de un tipo se controla mediante el nivel de accesibilidad del propio tipo.

- **private:** solamente el código de la misma class o struct puede acceder al tipo o miembro.

- **protected:** solamente el código de la misma class, o bien de una class derivada de esa class, puede acceder al tipo o miembro.

- **internal:** Puede obtener acceso al tipo o miembro cualquier código del mismo ensamblado, pero no de un ensamblado distinto. En otras palabras, se puede acceder a tipos o miembros internal desde el código que forma parte de la misma compilación.

- **protected internal:**cualquier código del ensamblado en el que se ha declarado, o desde una class derivada de otro ensamblado, puede acceder al tipo o miembro.

- **private protected:** se puede tener acceso al tipo o miembro mediante tipos derivados del objeto class que se declaran dentro de su ensamblado contenedor.

**Recomendaciones:**

- Si la propiedad tiene un modificador de acceso privado, el nombre de la propiedad debe ir en camelCase, en caso de que sea de acceso público, el nombre de la propiedad debe de ir en PascalCase.

Ejemplo:

```C#
class Persona
{
    private string nombre;
    public int Edad;
}
```

## Clase 5 - Concepto de clases y objetos

- Elemento principal en POO.
- Se basa en propiedades que representan las características del Objeto y métodos que definen el comportamiento.
- Se pueden definir como la plantilla base para crear los objetos.

Los métodos son funciones que existen en cualquier lenguaje de programación, cuando las funciones están dentro de las clases las llamamos métodos, la particularidad que tienen los métodos es que definen el comportamiento de la clase.

Los objetos son instancias de las clases, se llaman instancias ya que los objetos quedan haciendo referencia a la clase a partir de la que se crearon. Los objetos toman las propiedades y métodos de la clase pero los valores quedan siendo diferentes para cada objeto.

Los objetos se usan para guardar datos o ejecutar acciones que define la clase.

## Clase 6 - Creando clases y propiedades

El objetivo de las clases es nombrarlas en forma singular ya que representa un objeto.

Se crea la clase base "SuperHeroe" para seguir trabajando en los temas del curso.
