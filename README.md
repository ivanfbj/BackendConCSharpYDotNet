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

## Clase 7 - Creando clases complejas

Las enumeraciones en C\# nos permiten asignar valores especificos o crear una lista de valores especificos y forzar al desarrollador que va a utilizar la clase a asignar cualquier de los valores de las enumeraciones.

En los usos de las clases es posible utilizar una clase para asignarla como TIPO a una porpiedad de otra clase, en el ejemplo tenemos la clase `SuperPoder` el cual se está utilizando en la propiedad "SuperPoderes" de la clase `SuperHeroe`, lo que nos permite crear una lista de superpoderes para cada objeto que se instancie de la clase `SuperHeroe`.

## Clase 8 - Constructor y datos iniciales en una clase

El constructor nos permite inicializar los valores de un objeto que es creado a partir de una clase.

La idea de un constructor es crear una función que nos ayude a inicializar los valores o especificar datos por defecto al momentos de crear los objetos, esto ayuda a que al inicializar un objeto, venga con ciertos valores, para no tenerlos que asignar luego de crear el objeto, ayuda a minimizar el código.

Para inicializar un constructor es necesario crear una función que no va a retornar ningún tipo de valor y se utiliza el mismo nombre de la clase. Dentro de esa función se puede inicializar las variblaes como se requiera o ejecutar rutinas según se requiera.

Cuando se realiza la creación del objeto por medio de la clase, se creará con los valores definidos en el contructor.

## Clase 9 - Métodos dentro de una clase

Los métodos personalizados nos ayudan a definir el comportamiento de los objetos.

Un método es una función dentro de la clase para poder realizar alguna acción dentro de la clase.

La línea `StringBuilder sb = new StringBuilder();` me permite concatenar varios string en una sola variable, para eso se complementa con `sb.AppendLine("stringAConcatener")` y `sb.ToString()` para retornar los datos.

## Clase 10 - Tipos registro y estructura

**Tabla comparativa**:

| Clase                     | Estructura         | Registro                      |
|---------------------------|--------------------|-------------------------------|
| Referencia                | Valor              | Valor o referencia            |
| Grandes                   | Pequeñas           | Pequeñas                      |
| Valores y comportamientos | Enfocada a valores | Enfocada a valores inmutables |

Una particularidad que tienen las clases es que la forma en la que se crean o comparan los elementos dentro del código es a travez de referencia, esto significa que cada vez que se cree un objeto con esa clase se va a apartar una posición de memoria para apartar los datos de ese objeto y se le va a asignar un identificar a esa posición de memoria. Esto significa que si creamos otro objeto con exactamente los mismo valores y datos, de toda manera va a ser un objeto diferente al primer objetos que creamos, ya que cada uno de estos va a tener una referencia diferente.

Las clases se puede utilizar en cualquier nivel de complejidad, ya sea un componente pequeño, mediano o grande, podemos utilizar clases, lo que permite mayor versatilidad.

Las clases son enfocadas en valores y comportamientos, es decir, cuando se tienen que creear datos pero también muchos métodos o funciones dentro de la clase para poder manipular eso datos.

## Clase 11 - Modificadores de acceso

Quienes tienen accesos a las clases, propiedades y métodos.

**Lista de modificadores**:

- **public**: el acceso no está restringido. (Exponer a cualquiera que este por fuera del contexto de la clase, pueda utilizar ese método o propiedad a cualquiera que este creando objeto con la clase.)
- **protected**: el acceso está limitado a la clase contendora o a los tipos derivados de la clase contenedora. (Las clases que heren de la clase principal podrán utilizar los métodos o propiedades de la clase.)
- **internal**: el acceso está limitado al ensamblado actual. (Solo se utilice internamente dentro del proyecto del cual se está trabajando, no serán visibles para otros proyectos.)
- **private**: El acceso está limitado al tipo contenedor. (Evitar que cualquiera que este por fuera del contexto de la clase, no pueda utilizar ese método o propiedad.)
- **protected internal**: El acceso está limitado al ensamblado actual o a los tipos derivados de la clase contenedora.
- **private protected**: El acceso está limitado a la clase contenedora o a los tipos derivados de la clase contenedora que hay en el ensamblado actual.

______

A nivel del código se procede a realizar un cambio el cual implica mover las clases `SuperHeroe` y `SuperPoder`, a sus propios archivos de clases `SuperHeroe.cs` y `SuperPoder.cs`, y para poder utilizar dichas clases desde la clase `Program.cs` es necesario realizar la importación del espacio de trabajo por medio de

```C#
using proyecto.carpeta
```

lo que se convierte en este proyecto en:

```C#
using cursoDeProgramacionOrientadaAObjetosConCSharp.Models;
```

## Clase 12 - Encapsulamiento

Se refiere a la idea de ocultar los detalles internos de un objeto y proporcionar una interfaz pública bien definida para interactuar con él.

El encapsulamiento permite controlar el acceso a los atributos y métodos de un objeto, lo que ayuda a mantener la integridad de los datos y facilita la gestión y el mantenimiento del código.

En el encapsulamiento, los atributos de un objeto se declaran como privados, lo que significa que solo pueden accederse y modificarse desde dentro de la propia clase a la que pertenece el objeto.

Para permitir que otros objetos interactúen con estos atributos, se proporcionan métodos públicos, también conocidos como métodos de acceso o getters y setters, que permiten obtener y establecer los valores de los atributos de manera controlada.

Los beneficios del encapsulamiento son:

1. Control de acceso: Se puede especificar quién tiene acceso a los datos y quién no. Esto ayuda a prevenir modificaciones no deseadas o inconsistentes en los datos.

2. Ocultamiento de detalles internos: Los detalles de implementación de una clase se mantienen ocultos, lo que facilita el cambio de la implementación sin afectar a los objetos que la utilizan.  

3. Facilita la mantenibilidad: Al tener una interfaz pública bien definida, es más fácil identificar y corregir problemas en el código, ya que se sabe dónde se realizan las interacciones con el objeto.

En C# el encapsulamiento se logra utilizando modificadores de acceso como "**private**", "**public**" y "**protected**" para controlar el acceso a los atributos y métodos de una clase.

En el código se del archivo `Program.cs` el nombre del superHeroe contiene espacios, por lo cual se va a realizar un encapsulamiento del atributo `Nombre` para poder limpiar el nombre:

Ejemplo:

```C#
SuperHeroe superman = new();

superman.Id = 1;
superman.Nombre = "        Superman            ";
```

Para el encapsulamiento lo que se realiza es que en la clase `SuperHeroe.cs` se van a crear 2 atributos para guardar el "Nombre", un atributo privado y otro público, el atributo privado contendra la información ya depurada y sin errores o espacios adicionales y al atributo público tendrá el GET y el SET que será el encapsulamiento del atributo "Nombre", el cual en el SET se encargará de limpiar de los espacios al inicio y al final antes de guardar el datos en el atributo privado:

Ejemplo:

```C#
private string _Nombre;

public string Nombre
{
    get
    {
        return _Nombre;
    }

    set
    {
        _Nombre = value.Trim();
    }
}

```

Al encapsular la propiedad, en el momento de guardar el dato se limpian los espacios al inicio y al final.

Otro tipo de encapsulamiento es reutilizar otras propiedades que ya tiene la clase para encapsularlas y crear una nueva propiedad que encapsula un comportamiento en particular:

Ejemplo:

```C#
public string NombreEidentidadSecreta
{
    get
    {
        return $"{_Nombre} ({IdentidadSecreta})";
    }
}
```

## Clase 13 - ¿Que es herencia?

Lla herencia permite que una clase herede atributos y métodos de otra clase. Es una forma de reutilizar el código para así, establecer relaciones entre las clases.

Ejemplo:

clase Animal->(clase base)
clase Perro ->( clase derivada de Animal)
clase Gato->(Clase derivada de Animal)

En este caso Perro y Gato heredan propiedades comunes de Animal como lo sería Nombre, Edad y pueden tener sus propiedades y métodos específicos como ladrar en Perro y Maullar en Gatos.

Herencia en C#:

- Se usan los dos puntos para especificar la clase padre luego del nombre de la clase hija:

```C#
public class ClaseHija : ClasePadre
```

**Nota:**
En C# solo podemos heredar de una clase o no podemos heredar de múltiples clases.

## Clase 15 - Abstracción

Se busca crear componente más genericos que no contengan un detalle o definición y esto va a permitir en muchos escenarios poder reautilar más el código y utilizar conceptos avanzados como los patrones de diseño.

Las clases abstractas obligan a las clases que la heredan a implementar sus métodos abstractos:

- Si una clase contiene un método abstracto la clase tambien debe ser abstracta.

- Cuando en una clase abstracta se crean submétodos, estos no pueden contener un cuerpo de dicho método.

- Cuando se hereda de una clase abstracta que contiene métodos o propiedades abstractas por obligación la clase que lo hereda tiene que implementarla con la palabra reservada override y crear el cuerpo de los métodos.

A nivel de código se crear una nueva clase llamada `Heroe.cs` dicha clase se crea abstracta y con un método de tipo abstracto, este método solamente es el nombre y no contiene ningúna lógica interna.

Al poner la clase `SuperHeroe.cs` como hija de la clase `Heroe.cs` el sistema nos indica que es neceserio implementar el método abstracto de la clase `Heroe.cs` en forma de **override**.

Al implementar **abstract** ya sea en una propiedad o método obliga a la clase hija a que tenga que relizar el **override**.

La clase abstracta puede contener métodos que no sean abstractos, con base en esto no es obligatorio para la clase hija que tenga que utilizar dicho método con override. En caso de que el objeto creado desde la clase hija requiera utilizar dicho método, lo puede hacer sin ningún tipo de error.

## Clase 16 - Polimorfismo

Permite que la clase padra e hija tengan el mismo método pero en cada una de las clases se comporta o funciona de una forma diferente.

Para indicar que un método va a ser de tipo **Polimorfismo**, al método se le agrega la palabra clave **virtual** en la clase padre, el método sigue siendo opcional su implementación en la clase hija.

Si se va a implmenetar en la clase hija, se debe utilizar la palabra clave **override** para especificar que se va a sobreescribir el método.

Con la clausula "base." se puede dejar el mismo comportamiento del método que proviene desde el método padre o en caso se ser necesario se cambiar la lógica.

Método en la clase hija:

```C#
  public override string SalvarLaTierra()
  {
      return base.SalvarLaTierra();
  }
```

## Clase 17 - ¿Qué es una interfaz?

- Un contrato para garantizar la estructura de una clase.
- Permite elementos abstractos e implementaciones por defecto.
- Ayudan a desacoplar el código.
- C# soporta implementación de múltiples interfaces.

**Características:**

- Normalmente se declaran con **I**Nombre
- Se utilizan en casi todos los patrones de diseño para .NET
- Podemos implementar generics para utilizar la misma interfaz en diferentes escenarios. Ejemplo: **IList\<T>**

Las diferencias principales entre las interfaces y las clases son:

- Las interfaces no pueden tener instancias. Una interfaz solo puede ser implementada por un tipo de datos.

- Las interfaces solo pueden definir métodos, propiedades y eventos. Las clases pueden definir datos de instancia, métodos, propiedades y eventos.

- Las interfaces se utilizan para especificar el comportamiento. Las clases se utilizan para definir tipos de datos.

