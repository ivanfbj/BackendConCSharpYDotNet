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

**S:** Single responsibility principle - Principio de responsabilidad única
**O:** Open/closed principle - Principio de abierto/cerrado
**L:** Liskov substitution principle - Principio de sustitución de Liskov
**I:** Interface segregation principle - Principio de segregación de la interfaz
**D:** Dependency inversion principie - Principio de inversión de la dependencia

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
