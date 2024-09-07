// csc Program.cs
// Program.exe
using System;

namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Calculadora(+ - / *) *****");
            Console.Write("\nPresione ENTER para continuar, cualquier otra tecla para salir: ");
            string enter = Console.ReadLine();
        
            bool start = enter == "" ? true : false;

            while (start)
            {
                // Consulta de la operacion al usuario
                Console.Write("\nIngrese el primer número: ");
                string number1 = Console.ReadLine();
                Console.Write("Ingrese la operación: ( + | - | / | x) ");
                string operation = Console.ReadLine();
                Console.Write("Ingrese el segundo número: ");
                string number2 = Console.ReadLine();
                Console.WriteLine("\nCalculando: " + number1 + operation + number2 + " = ...");

                double num1 = Convert.ToDouble(number1);
                operation = operation.ToLower();
                double num2 = Convert.ToDouble(number2);
                double result = 0;

                // Realizar calculo matematico
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Resultado: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Resultado: " + result);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine("Resultado: " + result);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir con 0");
                        }
                        break;
                    case "x":
                        result = num1 * num2;
                        Console.WriteLine("Resultado: " + result);
                        break;
                    default:
                        Console.WriteLine("Operación no válida");
                        break;
                }

                // Salida del bucle
                Console.Write("\nPresione ENTER para continuar / (S) para salir: ");
                string exit = Console.ReadLine();
                start = exit == "" ? true : false;
            }
        }
    }
}