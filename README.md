# Curso de Principios SOLID en C# y .NET

## Clase 1 - Principios SOLID en C# y .NET

- Aprendizaje de los principios SOLID para aplicarlos en los desarrollo.
- Se analizará cada principio desde la teoria y luego se analizará un ejemplo practico en un código mal implementado, para luego implementar el principio SOLID que le correspondería.

## Clase 2 - Prerrequisitos

- Conocimiento en C# y .NET
- Conocimiento de Git
- Visual Code o Visual Studio
- .NET 6 0 superior

## Clase 3 - ¿Qué son las buenas prácticas y el código limpio?

**Buenas prácticas:**

- Resuelven desafíos de escenarios comunes.
- Estándares comprobados y verificados.
- Brindan guías fáciles de aprender y comprender.
- Permiten tener una estructura similar para múltiples proyectos.

**Código limpio:**

- Código fácil de entender y analizar.
- Código fácil de mantener.
- Código fácil de actualizar.
- Código fácil de escalar.

**Cómo logramos código limpio:**

- Mantener bajo acoplamiento. (Evitar que existan muchas dependencias entre componentes)
- Utilizar sintaxis simple y actual.
- Evitar incorporar muchas librerías de terceros.
- Distribución de responsabilidades
- Creación de componentes pequeños.

**SOLID** nos ayuda a **tener código limpio y buenas prácticas**

## Clase 4 - ¿Qué son los principios SOLID?

Cada letra de la palabra SOLID, representa un principio en particular:

**S:** Single responsibility principle - Principio de responsabilidad única.  
**O:** Open/closed principle - Principio de abierto/cerrado.  
**L:** Liskov substitution principle - Principio de sustitución de Liskov.  
**I:** Interface segregation principle - Principio de segregación de la interfaz.  
**D:** Dependency inversion principie - Principio de inversión de la dependencia.  

**S:** Asignar una unica responsabilidad a cada uno de los componentes involucrados en el sistema.  
**O:** Un código debe estar abierto a extensiones y cerrado para cambios.  
**L:** Habla de la relación que deben tener los tipos y subtipos dentro de un sistema.  
**I:** Nos ayuda a asignar una responsabilidad especifica a cada una de la interfaces que tiene el sistema, los tipos abstractos que estemos utilizando.  
**D:** Habla del concepto de inyección de dependencias y la importancia para evitar dependencias directas entre un componente y otro, para evitar el acoplamiento de un sistema.  

**Característica de SOLID:**

- Orientada al paradigma de orientación a objetos (POO).
- Se le atribuye a Robert C. Martin.
- Diseño y refactorización de código.
- Se debe implementar desde el inicio del proyecto cuando se crean los componentes.

**SOLID Ayuda a:**

- Lograr código escalable.
- Evitar deuda técnica (Technical debt).
- Plantear los fundamentos para el desarrollo guiado por pruebas (TDD).
- Tener un estándar claro en cada uno de los proyectos de un portafolio.

**Lecturas recomendadas:**
[Procedimientos recomendados en C#](https://learn.microsoft.com/es-es/archive/msdn-magazine/2014/may/csharp-best-practices-dangers-of-violating-solid-principles-in-csharp)

## Clase 5 - Conociendo el principio de responsabilidad única

- Single responsibility principle
- Distribuye las responsabilidades en diferentes componentes dentro de un sistema, donde cada componente tiene una única responsabilidad
- Aplica para módulos, clases, métodos y funciones.

Ejemplo: (Una idea de como analizar una historia de usuario, aplicando el principio de responsabilidad única)

Como usuario luego de confirmar la compra espero ver un **mensaje de confirmación**, tener la posibilidad de **descargar la factura** y un **correo electrónico de confirmación**.

Demo - Escenario:
Tenemos una clase StudentRepository encargada de administrar los datos para el modelo student, pero en este momento no cumple con el principio de responsabilidad única, debe solucionarse.

## Clase 6 - Aplicando el principio de responsabilidad única

Demo - Escenario:
Tenemos una clase StudentRepository encargada de administrar los datos para el modelo student, pero en este momento no cumple con el principio de responsabilidad única, debe solucionarse.

Esta clase debe tener alguna funcionalidad adicional que no deberia de estar realizando y se debe corregir.

Carpeta: **1-SingleResponsability**

- `Students.cs`: es el módelo con sus respectivos atributos y constructures.
- `FakeStorage.cs`: Brinda una interfaz generica para poder manejar información en memoria. Ayuda a la administración de los datos para no tener que utilizar una base de datos.
- `StudentRepository.cs`: Es la clase que tiene problemas y la que se debe ajusta con el principio de responsabilidad unica.
El problema de la clase está en el método "Export" ya que allí se encuentra una lógica que se encarga de exportar datos y la clase `StudentRepository.cs` solo debe tener la responsabilidad de manipular los datos de "Student".

Para separar esta lógica, lo que se debe hacer es crear la clase `ExportHelper.cs`

En el archivo `Program.cs` se puede evidenciar los cambios realizados, donde la clase `StudentRepository.cs` queda con la responsabilidad de manipular los datos de estudiantes, mientras que la clase `ExportHelper.cs` queda con la responsabilidad de exportar datos.

## Clase 7 - Conociendo el principio de abierto/cerrado

- Open/closed principle
- Bertrand Meyer - Robert Martin.
- Un componente debe ser abierto para extensiones y cerrado para cambios. (No se debería de mover código existente y funcional, solo que también debe estar preparada para poderse extender.)
- Se deben utilizar tipos abstractos y múltiples implementaciones para lograrlo. (apoyarnos en las interfaces)

En el caso de **C#** debido a que no soporta multiples gerencias, se pueden implementar múltiples interfaces.

Demo - Escenario

Tenemos un proyecto que tiene una clase **EmployeeFullTime** para empleados a tiempo completo y **EmployeePartTime** para medio tiempo y necesitamos agregar **EmployeeContractor** para empleados externos cumpliendo con el principio Abierto/Cerrado.

Carpeta: **2-OpenClose**

## Clase 8 - Aplicando el principio abierto/cerrado

Demo - Escenario

Tenemos un proyecto que tiene una clase **EmployeeFullTime** para empleados a tiempo completo y **EmployeePartTime** para medio tiempo y necesitamos agregar **EmployeeContractor** para empleados externos cumpliendo con el principio Abierto/Cerrado.

Carpeta: **2-OpenClose**

El `Program.cs` hay un método que recibe una lista de los 2 tipos de empleados y se encarga de calcular el salario, en el momento de implementar la nueva clase que solicitan, se debe hacer una modificación en la clase `Program.cs` ya que tiene un condicional if-else.

La clase `Program.cs` no cumple con el principio de responsabilidad única ya que dicha clase se debe encargar unicamente de realizar la ejecución del programa y no contener lógica adicional para calcular el salario mensual de los trabajadores.

Se crea la clase abstracta llamada `Employee.cs`, al ser la clase padre que va a tener las referencias para todas las demás clases, debe contener las propiedades que se van a reutilizar en todas las clases.

Se requiere que la clase de cada uno de los tipos de empleados realice su propio cálculo de salario y no que se realice desde la clase `Program.cs`.

Una vez se crea la nueva clase `Employee.cs`, se eran sus atributos y métodos a las clases `EmployeeFullTime.cs` y `EmployeePartTime.cs`, y la lógica para calcaular el salario del empleado se mueve de la clase `Program.cs` a cada clase de tipo de empleado.

Con los cambios realizados, osea crear y **extender** la clase `Employee.cs`, nos permite extender de una forma más fácil las funcionalidades y así poder crear más rápida y fácilmente la clase `EmployeeContractor.cs`.

## Clase 9 - Conociendo el principio de sustitución de Liskov

- Liskov substitution principle
- Barbara Liskov - Robert Martin
- Tipo / Subtipo
- Los objetos dentro de un programa deben poderse reemplazar por subtipos de este sin alterar la lógica o el funcionamiento.

- Sea (x) una propiedad comprobable acerca de los objetos x de tipo T. Entonces debe ser verdad para los objetos y del tipo S, donde S es un subtipo de T.

Demo - Escenario

En una aplicación tenemos 2 tipos de empleados, contractor y full-time, solo un empleado full-time tiene derecho a horas extras. El valor de la hora es 50 para full-time y de 40 para contractor. Ajustar el código para cumplir con los principios SOLID.

## Clase 10 - Aplicando el principio de sustitución de Liskov

Se realizan ajustes sobre la clase ya que el código no solamente no cumple con el principio de substitución Liskov sino con el principio de abierto/cerrado.

Esto se debe a que la clase Employee no deberia de contener el atributo de horas extras, ya que es una condición que solo aplica a empleados tipo FullTime y no de tipo Contractor.

La clase de tipo padre debe de tener las implementación que apliquen para todos los subtipos.

En en código final se puede evidenciar que los subtipos o subclases `EmployeeFullTime.cs` y `EmployeePartTime.cs` quedarón exactamente con los mismos tipos (atributos y método) que el tipo o clase padre `Employee.cs`, cada subclase tiene sus propios comportamientos y funcionamiento.

