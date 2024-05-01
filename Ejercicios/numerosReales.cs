    class Programa
    {
        static void Main()
        {
            Console.Write("Ingrese la cantidad de números reales: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            float[] arreglo = new float[cantidadNumeros];
            Console.WriteLine("Ingrese los números reales:");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                arreglo[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArreglo en desorden:");
            foreach (float numero in arreglo)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine("\n\nArreglo en orden ascendente:");
            Array.Sort(arreglo);
            foreach (float numero in arreglo)
            {
                Console.Write(numero + " ");
            }
        }
    }
