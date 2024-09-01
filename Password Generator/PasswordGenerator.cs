using System;

public class PasswordGenerator
{
    // Configuración Básica
    // Estas variables almacenarán los diferentes grupos de caracteres que se utilizarán para generar la contraseña
    private string upperLetters = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
    private string lowerLetters = "abcdefghijklmnñopqrstuvwxyz";
    private string numbers = "1234567890";
    private string specialCharacters = "!@#$%^&*_=+|;:/?>";

    // Crear el Método para Generar la Contraseña
    public string GeneratePassword(int length = 12)
    {
        // Combinar los Caracteres Permitidos
        string allowedCharacters = upperLetters + lowerLetters + numbers + specialCharacters;

        // Inicializar el Generador Aleatorio
        Random random = new Random();

        // Crear un String Vacío para almacenar la Contraseña
        string password = "";

        // Bucle para generar la contraseña
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(allowedCharacters.Length);
            password += allowedCharacters[index];
        }

        // Retornamos la contraseña generada
        return password;
    }
}