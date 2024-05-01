using System;
class taller
{
    static void Main(string[] args)
    {
        string[] documentos = new string[100];
        string[] nombres = new string[100];
        int[] inasistencias = new int[100];
        int contadorAprendices = 0;
        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Registrar inasistencias");
            Console.WriteLine("2. Listar todas las inasistencias");
            Console.WriteLine("3. Listar los aprendices con inasistencias superiores a 3");
            Console.WriteLine("4. Consultar el total de inasistencias por aprendiz");
            Console.WriteLine("5. Valor a Pagar");
            Console.WriteLine("6. Número de suerte");
            Console.WriteLine("7. Salir");

            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarInasistencias(documentos, nombres, inasistencias, contadorAprendices);
                    break;
                case 2:
                    ListarTodasInasistencias(documentos, nombres, inasistencias, contadorAprendices);
                    break;
                case 3:
                    ListarInasistenciasSuperioresA3(documentos, nombres, inasistencias, contadorAprendices);
                    break;
                case 4:
                    ConsultarTotalInasistenciasPorAprendiz(documentos, nombres, inasistencias, contadorAprendices);
                    break;
                case 5:
                    CalcularValorAPagar();
                    break;
                case 6:
                    GenerarNumeroSuerte();
                    break;
                case 7:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
                    break;
            }
        }
    }
    static void RegistrarInasistencias(string[] documentos, string[] nombres, int[] inasistencias, int contadorAprendices)
    {
        Console.Write("Ingrese el documento del aprendiz: ");
        string documento = Console.ReadLine();
        int indice = Array.IndexOf(documentos, documento);

        if (indice == -1)
        {
            Console.Write("Ingrese el nombre completo del aprendiz: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad de inasistencias (entre 1 y 100): ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad >= 1 && cantidad <= 100)
            {
                documentos[contadorAprendices] = documento;
                nombres[contadorAprendices] = nombre;
                inasistencias[contadorAprendices] = cantidad;
                contadorAprendices++;
                Console.WriteLine("Inasistencias registradas correctamente.");
            }
            else
            {
                Console.WriteLine("Cantidad de inasistencias no válida.");
            }
        }
        else
        {
            Console.Write("El aprendiz ya está registrado. Ingrese la cantidad de inasistencias actualizada: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad >= 1 && cantidad <= 100)
            {
                inasistencias[indice] = cantidad;
                Console.WriteLine("Inasistencias actualizadas correctamente.");
            }
            else
            {
                Console.WriteLine("Cantidad de inasistencias no válida.");
            }
        }
    }

    static void ListarTodasInasistencias(string[] documentos, string[] nombres, int[] inasistencias, int contadorAprendices)
    {
        Console.WriteLine("Inasistencias registradas:");
        for (int i = 0; i < contadorAprendices; i++)
        {
            Console.WriteLine($"Documento: {documentos[i]}, Nombre: {nombres[i]}, Inasistencias: {inasistencias[i]}");
        }
    }

    static void ListarInasistenciasSuperioresA3(string[] documentos, string[] nombres, int[] inasistencias, int contadorAprendices)
    {
        Console.WriteLine("Aprendices con inasistencias superiores a 3:");
        for (int i = 0; i < contadorAprendices; i++)
        {
            if (inasistencias[i] > 3)
            {
                Console.WriteLine($"Documento: {documentos[i]}, Nombre: {nombres[i]}, Inasistencias: {inasistencias[i]}");
            }
        }
    }

    static void ConsultarTotalInasistenciasPorAprendiz(string[] documentos, string[] nombres, int[] inasistencias, int contadorAprendices)
    {
        Console.Write("Ingrese el documento del aprendiz: ");
        string documento = Console.ReadLine();
        int indice = Array.IndexOf(documentos, documento);

        if (indice != -1)
        {
            Console.WriteLine($"Documento: {documentos[indice]}, Nombre: {nombres[indice]}, Inasistencias: {inasistencias[indice]}");
        }
        else
        {
            Console.WriteLine("El documento ingresado no corresponde a ningún aprendiz registrado.");
        }
    }

    static void CalcularValorAPagar()
    {
        Console.WriteLine("Ingrese los datos de la venta:");
        Console.Write("Código: ");
        string codigo = Console.ReadLine();
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Precio: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (precio <= 0 || cantidad <= 0)
        {
            Console.WriteLine("El precio y la cantidad deben ser mayores que cero.");
            return;
        }

        double valorBruto = precio * cantidad;
        double descuento = cantidad > 10 ? valorBruto * 0.1 : 0;
        double iva = valorBruto * 0.19;
        double valorTotal = valorBruto + iva - descuento;

        Console.WriteLine($"Valor a pagar: {valorTotal}");
    }

    static void GenerarNumeroSuerte()
    {
        Random rnd = new Random();
        int numero = rnd.Next(0, 1000);
        string numeroSuerte = numero.ToString("D3");
        Console.WriteLine($"Número de la suerte: {numeroSuerte}");
    }
}