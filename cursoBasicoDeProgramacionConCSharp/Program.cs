// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Clase 7 - Variables

//Programa que calcula el área de un rectángulo
double ladoA; //Declaración de Variable
double ladoB; //Declaración de Variable
double resultado; //Declaración de Variable

Console.WriteLine("Clacula el área de un rectángulo!!");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToInt32(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El resultado es: " + resultado);