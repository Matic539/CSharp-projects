// csc Program.cs PasswordGenerator.cs
// Program.exe
using System;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator g = new PasswordGenerator();

            Console.WriteLine("\n**********  GENERADOR DE CONTRASEÑAS  **********");
            Console.Write("Caracteres minimos para una contraseña segura ( NUMERO ): ");
            string characters = Console.ReadLine();

            // Convertir string characters a int
            int numberCharacters;
            bool number = int.TryParse(characters, out numberCharacters);

            // Verificar que se ingreso un numero 
            if (number)
            {
                // Se genera la contraseña con el largo ingresado
                Console.WriteLine("\nContraseña generada: "+ g.GeneratePassword(numberCharacters));
            }
            else
            {
                // Se genera la contraseña con el largo predeterminado de la clase (12)
                Console.WriteLine("\nContraseña generada: "+ g.GeneratePassword());
            }
        }
    }
}