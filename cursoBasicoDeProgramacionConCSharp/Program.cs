
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
//var radio = 0d;
//var resultado = 0d;

//const double Pi = 3.14; //La convención de las constantes son PascalCase.

//Console.WriteLine("Bienvenido, calculemos círculos");

//Console.WriteLine("Ingrese el valor del radio");
//radio = Convert.ToDouble(Console.ReadLine());

//resultado = Pi * radio * radio;

//Console.WriteLine("El área de tu círculo es: " + resultado);
#endregion

#region Clase 10 - Operadores aritméticos
////Programa que calcula el área de un rectángulo
//var ladoA = 0d; //Declaración de Variable
//var ladoB = 0d; //Declaración de Variable
//var resultado = 0d; //Declaración de Variable

//Console.WriteLine("Clacula el área de un rectángulo!!");
//Console.WriteLine("Ingrese el valor del lado A");
//ladoA = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Ingrese el valor del lado B");
//ladoB = Convert.ToDouble(Console.ReadLine());

//resultado = ladoA * ladoB; //El * es el operador de multiplicación
//Console.WriteLine("El resultado es: " + resultado);

//ladoA++; //El ++ es un operador de incremento, suma 1 a la variable.
//ladoA--; //El -- es un operador de decremento, resta 1 a la variable.
//double resultado2 = ladoA / ladoB; //El / es el operador de multiplicación
//double resultado3 = ladoA % ladoB; //El % es el operador de residuo, devuelve el restante de una división.
#endregion

#region Clase 11 - Operadores lógicos

//bool a = true;
//bool b = false;
//bool c = (a && b); // c es false
//bool d = (a || b); // d es true
//bool e = !b; // e es true
//bool f = (a ^ b); // f es true

//Console.WriteLine("El resultado a es: " + a);
//Console.WriteLine("El resultado b es: " + b);
//Console.WriteLine("El resultado c es: " + c);
//Console.WriteLine("El resultado d es: " + d);
//Console.WriteLine("El resultado e es: " + e);
//Console.WriteLine("El resultado f es: " + f);
#endregion

#region Clase 12 - Operadores relacionales
//int x = 5;
//int y = 10;
//bool a = (x == y); // a es false
//bool b = (x != y); // b es true
//bool c = (x > y); // c es false
//bool d = (x < y); // d es true
//bool e = (x >= y); // e es false
//bool f = (x <= y); // f es true

//Console.WriteLine("El resultado a es: " + a);
//Console.WriteLine("El resultado b es: " + b);
//Console.WriteLine("El resultado c es: " + c);
//Console.WriteLine("El resultado d es: " + d);
//Console.WriteLine("El resultado e es: " + e);
//Console.WriteLine("El resultado f es: " + f);
#endregion

#region Clase 13 - Strings en C#
//int altura = 168;
//int edad = 89;
//string nombre = "Ricardo Perez";
//string informacion = "Nació en Hidalgo, es estudiante de gastronomía y astronomía";
//var hobby = "deportista";

//// String interpolation:
//string tarjetaDeIndentificacion = $"La información de {nombre} " +
//    $"es la siguiente, su edad es {edad} años,\n su altura es de {altura} cms.\nInformación relevante {informacion}\n además su hobby es de: {hobby}";

//Console.WriteLine(tarjetaDeIndentificacion);

#endregion

#region Clase 14 - Condicional IF
//int totalJugador = 10;
//int totalDealer = 15;
//string message = string.Empty;

////BIackjack, Juntar 21 pidiendo cartas o en caso de tener menos
////de 21 igual tener mayor puntuación que el dealer

//if (totalJugador > totalDealer && totalJugador <= 21)
//{
//    message = "Venciste al dealer,felicidades";

//}
//else if (totalJugador >= 22)
//{
//    message = "Perdiste vs el dealer, te pasaste de 21";
//}
//else if (totalJugador <= totalDealer)
//{
//    message = "Perdiste vs el dealer, lo siento";
//}
//else
//{
//    message = "condición no válida.";
//}
//Console.WriteLine(message);

#endregion

#region Clase 15 - Condicional Switch
//int valorMano = 23; // Este sería el valor de la mano del usuario en Blackjack

//switch (valorMano)
//{
//    case 21:
//        Console.WriteLine("¡Blackjack! ¡Felicidades, ganaste!");
//        break;
//    case int n when n > 21:
//        Console.WriteLine("¡Te pasaste de 21! Perdiste.");
//        break;
//    default:
//        Console.WriteLine("No tienes Blackjack ni te pasaste de 21. Sigue jugando.");
//        break;
//}
#endregion

#region Clase 16 - Ciclos While y Do While
//int totalJugador = 0;
//int totalDealer = 0;
//int num = 0;
//string message = string.Empty;
//string switchControl = "menu";

////BIackjack, Juntar 21 pidiendo cartas o en caso de tener menos
////de 21 igual tener mayor puntuación que el dealer

//while (true)
//{

//    switch (switchControl)
//    {
//        case "menu":
//            Console.WriteLine("Welcome al c a s i n o");
//            Console.WriteLine("Escriba '21' para jugar al 21");
//            switchControl = Console.ReadLine();
//            break;

//        case "21":

//            do
//            {
//                num = new Random().Next(1, 12);
//                totalJugador += num;
//                Console.WriteLine($"Toma tu primera carta, jugador, te salio:  {num}");
//                Console.WriteLine("¿Deseas otra carta?");
//            }
//            while (Console.ReadLine() == "Si" || Console.ReadLine() == "si" || Console.ReadLine() == "yes");

//            if (totalJugador > totalDealer && totalJugador <= 21)
//            {
//                message = "Venciste al dealer,felicidades";
//                switchControl = "menu";

//            }
//            else if (totalJugador >= 22)
//            {
//                message = "Perdiste vs el dealer, te pasaste de 21";
//                switchControl = "menu";
//            }
//            else if (totalJugador <= totalDealer)
//            {
//                message = "Perdiste vs el dealer, lo siento";
//                switchControl = "menu";
//            }
//            else
//            {
//                message = "condición no válida.";
//                switchControl = "menu";
//            }
//            Console.WriteLine(message);
//            break;
//        default:
//            Console.WriteLine("Valor ingresado no válido en el C A S I N O");
//            switchControl = "menu";
//            break;
//    }
//}
#endregion

#region Clase 17 - Ciclos para el juego de Platzino

//int num = 0;
//string message = string.Empty;
//string controlOtraCarta = string.Empty;
//string switchControl = "menu";

////BIackjack, Juntar 21 pidiendo cartas o en caso de tener menos
////de 21 igual tener mayor puntuación que el dealer

//while (true)
//{
//    int totalJugador = 0;
//    int totalDealer;
//    switch (switchControl)
//    {
//        case "menu":
//            Console.WriteLine("Welcome al c a s i n o");
//            Console.WriteLine("Escriba '21' para jugar al 21");
//            switchControl = Console.ReadLine();
//            break;

//        case "21":

//            do
//            {
//                num = new Random().Next(1, 12);
//                totalJugador += num;
//                Console.WriteLine($"Toma tu primera carta, jugador, te salio:  {num}");
//                Console.WriteLine("¿Deseas otra carta?");
//                controlOtraCarta = Console.ReadLine();
//            }
//            while (controlOtraCarta == "Si" || controlOtraCarta == "si" || controlOtraCarta == "yes");

//            totalDealer = new Random().Next(14, 23);
//            Console.WriteLine($"El dealer tiene {totalDealer}!");

//            if (totalJugador > totalDealer && totalJugador <= 21)
//            {
//                message = "Venciste al dealer,felicidades";
//                switchControl = "menu";

//            }
//            else if (totalJugador >= 22)
//            {
//                message = "Perdiste vs el dealer, te pasaste de 21";
//                switchControl = "menu";
//            }
//            else if (totalJugador <= totalDealer)
//            {
//                message = "Perdiste vs el dealer, lo siento";
//                switchControl = "menu";
//            }
//            else
//            {
//                message = "condición no válida.";
//                switchControl = "menu";
//            }
//            Console.WriteLine(message);
//            break;
//        default:
//            Console.WriteLine("Valor ingresado no válido en el C A S I N O");
//            switchControl = "menu";
//            break;
//    }
//}
#endregion

#region Clase 18 - Ciclos For

//int num = 0;
//int numeroCreditos = 0;
//string message = string.Empty;
//string controlOtraCarta = string.Empty;
//string switchControl = "menu";

////BIackjack, Juntar 21 pidiendo cartas o en caso de tener menos
////de 21 igual tener mayor puntuación que el dealer

//Console.WriteLine("Welcome al c a s i n o");
//Console.WriteLine("Cuántos créditos desea \n" +
//    "Recuerda que necesitas una por ronda de juego");

//numeroCreditos = int.Parse(Console.ReadLine());

//while (true)
//{
//    for (int i = 0; i < numeroCreditos; i++)
//    {

//        int totalJugador = 0;
//        int totalDealer;
//        switch (switchControl)
//        {
//            case "menu":

//                Console.WriteLine("Escriba '21' para jugar al 21");
//                switchControl = Console.ReadLine();
//                break;

//            case "21":

//                do
//                {
//                    num = new Random().Next(1, 12);
//                    totalJugador += num;
//                    Console.WriteLine($"Toma tu primera carta, jugador, te salio:  {num}");
//                    Console.WriteLine("¿Deseas otra carta?");
//                    controlOtraCarta = Console.ReadLine();
//                }
//                while (controlOtraCarta == "Si" ||
//                        controlOtraCarta == "si" ||
//                        controlOtraCarta == "yes");

//                totalDealer = new Random().Next(14, 23);
//                Console.WriteLine($"El dealer tiene {totalDealer}!");

//                if (totalJugador > totalDealer && totalJugador <= 21)
//                {
//                    message = "Venciste al dealer,felicidades";
//                    switchControl = "menu";

//                }
//                else if (totalJugador >= 22)
//                {
//                    message = "Perdiste vs el dealer, te pasaste de 21";
//                    switchControl = "menu";
//                }
//                else if (totalJugador <= totalDealer)
//                {
//                    message = "Perdiste vs el dealer, lo siento";
//                    switchControl = "menu";
//                }
//                else
//                {
//                    message = "condición no válida.";
//                    switchControl = "menu";
//                }
//                Console.WriteLine(message);
//                break;
//            default:
//                Console.WriteLine("Valor ingresado no válido en el C A S I N O");
//                switchControl = "menu";
//                break;
//        }
//    }
//}
#endregion

#region Clase 19 - Reto: bug entre ciclos
int num = 0;
int numeroCreditos = 0;
string message = string.Empty;
string controlOtraCarta = string.Empty;
string switchControl = "menu";

//BIackjack, Juntar 21 pidiendo cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer

Console.WriteLine("Welcome al c a s i n o");
Console.WriteLine("Cuántos créditos desea \n" +
    "Recuerda que necesitas una por ronda de juego");

numeroCreditos = int.Parse(Console.ReadLine());

while (true)
{
    for (int i = 0; i < numeroCreditos; i++)
    {

        int totalJugador = 0;
        int totalDealer;
        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("Escriba '21' para jugar al 21");
                switchControl = Console.ReadLine();
                i -= 1;
                break;

            case "21":

                do
                {
                    num = new Random().Next(1, 12);
                    totalJugador += num;
                    Console.WriteLine($"Toma tu primera carta, jugador, te salio:  {num}");
                    Console.WriteLine("¿Deseas otra carta?");
                    controlOtraCarta = Console.ReadLine();
                }
                while (controlOtraCarta == "Si" ||
                        controlOtraCarta == "si" ||
                        controlOtraCarta == "yes");

                totalDealer = new Random().Next(14, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}!");

                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    message = "Venciste al dealer,felicidades";
                    switchControl = "menu";

                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs el dealer, te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el dealer, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "condición no válida.";
                    switchControl = "menu";
                }
                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresado no válido en el C A S I N O");
                switchControl = "menu";
                break;
        }
    }
}
#endregion