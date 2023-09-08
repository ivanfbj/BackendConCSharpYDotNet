
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


#region Clase 7 - Variables

////Programa que calcula el área de un rectángulo
//double ladoA; //Declaración de Variable
//double ladoB; //Declaración de Variable
//double resultado; //Declaración de Variable

//Console.WriteLine("Clacula el área de un rectángulo!!");
//Console.WriteLine("Ingrese el valor del lado A");
//ladoA = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese el valor del lado B");
//ladoB = Convert.ToInt32(Console.ReadLine());

//resultado = ladoA * ladoB;
//Console.WriteLine("El resultado es: " + resultado);
#endregion

#region Clase 8 - La palabra reservada var

////Programa que calcula el área de un rectángulo
//var ladoA = 1.1; //Declaración de Variable
//var ladoB = 1.1; //Declaración de Variable
//var resultado = 1.1; //Declaración de Variable

//Console.WriteLine("Clacula el área de un rectángulo!!");
//Console.WriteLine("Ingrese el valor del lado A");
//ladoA = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Ingrese el valor del lado B");
//ladoB = Convert.ToDouble(Console.ReadLine());

//resultado = ladoA * ladoB;
//Console.WriteLine("El resultado es: " + resultado);
#endregion

#region Clase 9 - Uso de constantes
//Nota: Pi * radio*radio
var radio = 0d;
var resultado = 0d;

const double Pi = 3.14; //La convención de las constantes son PascalCase.

Console.WriteLine("Bienvenido, calculemos círculos");

Console.WriteLine("Ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * radio * radio;

Console.WriteLine("El área de tu círculo es: " + resultado);
#endregion