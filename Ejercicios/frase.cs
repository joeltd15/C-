using System;

class ComprobadorPalindromo
{

    static void Main(string[] args)
    {
        Console.Write("Ingrese una frase o palabra: ");
        string palabra = Console.ReadLine();


        palabra = palabra.ToLower().Replace(" ", "");


        bool Palindromo = true;
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                Palindromo = false;
                break;
            }
        }


        int numeroVocales = 0;
        foreach (char letra in palabra)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                numeroVocales++;
            }
        }


        if (Palindromo)
        {
            Console.WriteLine(palabra + " es un palíndromo.");
            Console.WriteLine("Número de vocales: " + numeroVocales);
        }
        else
        {
            Console.WriteLine(palabra + " no es un palíndromo.");
            Console.WriteLine("Número de vocales: " + numeroVocales);
        }
    }
}