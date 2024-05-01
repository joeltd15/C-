    using System;

    class ConversorDeDivisas
    {
        static float PrecioDolarAnterior;
        static float PrecioDolarActual;

        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Conversor de Divisas");

            Console.Write("Ingrese el precio anterior del dólar en pesos: ");
            PrecioDolarAnterior = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio actual del dólar en pesos: ");
            PrecioDolarActual = float.Parse(Console.ReadLine());

            CalcularVariacionDelDolar(PrecioDolarAnterior, PrecioDolarActual);


            Console.Write("\nIngrese la cantidad de dólares a convertir a pesos: ");
            float dolares = float.Parse(Console.ReadLine());
            Console.WriteLine($"{dolares} dólares equivalen a {ConvertirDolaresAPesos(dolares)} pesos.");
        }

        static float ConvertirDolaresAPesos(float dolares)
        {

            return dolares * PrecioDolarActual;
        }

        static void CalcularVariacionDelDolar(float anterior, float actual)
        {
            float variacion = ((actual - anterior) / anterior) * 100;
            Console.WriteLine($"\nEl precio del dólar ha variado en un {variacion}% desde {anterior} pesos a {actual} pesos.");
        }
    }