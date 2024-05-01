class program
{
    static void Main()
    {
        Credito credito = new Credito();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Compras");
            Console.WriteLine("1. Registrar el valor total de compras");
            Console.WriteLine("2. Realizar avances");
            Console.WriteLine("3. Pagar Crédito");
            Console.WriteLine("4. Consultar Cupo Crédito y Saldo por Pagar");
            Console.WriteLine("5. Consultar Total Puntos");
            Console.WriteLine("6. Salir");

            Console.WriteLine("seleccione una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor total de compra: ");
                    double valorCompra = double.Parse(Console.ReadLine());
                    credito.registrarCompra(valorCompra);
                    break;
                case 2:
                    Console.Write("Ingrese el valor del avance: ");
                    double valorAvance = double.Parse(Console.ReadLine());
                    credito.realizarAvance(valorAvance);
                    break;
                case 3:
                    Console.Write("Ingrese el valor a abonar: ");
                    double valorAbono = double.Parse(Console.ReadLine());
                    credito.pagarCredito(valorAbono);
                    break;
                case 4:
                    Console.WriteLine("Cupo de Crédito: " + credito.cupocredito);
                    Console.WriteLine("Saldo por Pagar: " + credito.saldopagar);
                    break;
                case 5:
                    Console.WriteLine("Total Puntos: " + credito.puntos);
                    break;
                case 6:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
                    break;
            }
        }
    }
}


class Credito
{
    double CupoCredito = 1000000;
    double SaldoPagar = 0;
    int Puntos = 0;

    public double cupocredito { get { return CupoCredito; } }
    public double saldopagar { get { return SaldoPagar; } }

    public int puntos { get { return Puntos; } }

    public void registrarCompra(double compra)
    {
        if (compra <= 0)
        {
            Console.WriteLine("El valor de la compra debe ser mayor a 0");
            return;
        }

        if (compra > CupoCredito - SaldoPagar)
        {
            Console.WriteLine("El valor de la compra excede el cupo disponible");
            return;
        }
        SaldoPagar += compra;
        if (compra >= 1000000)
        {
            int puntosGanados = (int)(compra * 0.01);
            Puntos += puntosGanados;
            Console.WriteLine($"Ha acumulado {puntosGanados} puntos por esta compra");
        }
    }

    public void realizarAvance(double avance)
    {
        if (avance <= 0)
        {
            Console.WriteLine("El valor del avance debe ser mayor que 0");
            return;
        }

        if (avance > CupoCredito - SaldoPagar)
        {
            Console.WriteLine("El valor del avance supera el cupo del credito");
            return;
        }
        SaldoPagar += avance;
        CupoCredito -= avance;
    }

    public void pagarCredito(double abono)
    {
        if (abono <= 0)
        {
            Console.WriteLine("El valor del abono debe ser mayor a 0");
            return;
        }
        if (abono > SaldoPagar)
        {
            Console.WriteLine("El valor del abono excede el saldo a pagar");
            return;
        }

        SaldoPagar -= abono;
    }

    public void totalpuntos(int puntos)
    {
        Console.WriteLine($"tienes {puntos} puntos acumulados ");
    }
}