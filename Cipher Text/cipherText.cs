using System;

namespace CipherText
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

			// Prepárese para el cifrado
			// solicite al usuario un mensaje secreto
			Console.WriteLine("Ingrese su mensaje: ");
			string message = Console.ReadLine().ToLower();
			// Convierte la cadena capturada en una matriz de caracteres
			char[] secretMessage = message.ToCharArray();
			// nueva matriz vacía de caracteres para almacenar el mensaje cifrado
			char[] encryptedMessage = new char[secretMessage.Length];

			// Encriptar
			// realizar el cifrado para cada letra del mensaje
			for (int i = 0; i < secretMessage.Length; i++)
			{
				char secretLetter = secretMessage[i];
				// posición del carácter actual en la matriz alphabet
				int index = Array.IndexOf(alphabet, secretLetter);
				// Agrega 3 a la posición de la letra 
				int newIndex = (index + 3) % alphabet.Length;
				// encuentra el nuevo carácter cifrado
				char letter = alphabet[newIndex];
				// Añade el carácter cifrado a la matriz 
				encryptedMessage[i] = letter;
			}

			// Probar y mejorar
			// Convierte la matriz de caracteres en una cadena
			string newMessage = String.Join("", encryptedMessage);
			Console.WriteLine(newMessage);
		}
	}
}