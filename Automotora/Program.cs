// csc Program.cs Vehicles.cs
// Program.exe
// Programa de una automotora donde el usuario podra consultar segun el tipo de vehiculo que lo solicite los detalles de este.
using System;

namespace Automotora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu de presentación
            string option = "";

            while (option != "4")
            {
                Console.WriteLine("\n***** Bienvenido a la Automotora *****\n");
                Console.WriteLine("1. Consultar por autos");
                Console.WriteLine("2. Consultar por motos");
                Console.WriteLine("3. Consultar por camiones");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese la opción deseada: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Car.ShowAllCarsInfo();
                        break;
                    case "2":
                        Motorcycle.ShowAllMotorcyclesInfo();
                        break;
                    case "3":
                        Truck.ShowAllTrucksInfo();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        } 
    }
}