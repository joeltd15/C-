using System;

public class Compra
{
    public int Codigo { get; set; }
    public string Proveedor { get; set; }
    public string Estado { get; set; }
    public float Total { get; set; }

    public Compra(int codigo, string proveedor, string estado, float total)
    {
        Codigo = codigo;
        Proveedor = proveedor;
        Estado = estado;
        Total = total;
    }

    public override string ToString()
    {
        return $"Código: {Codigo}, Proveedor: {Proveedor}, Estado: {Estado}, Total: {Total:C}";
    }
}

class Program
{
    static void Main()
    {
        Compra[] compras = new Compra[3];

        compras[0] = new Compra(1001, "Proveedor A", "Aprobado", 15000);
        compras[1] = new Compra(1002, "Proveedor B", "Pendiente", 23000);
        compras[2] = new Compra(1003, "Proveedor C",  "Rechazado", 75000);

        Console.WriteLine("Lista de compras:");
        foreach (var compra in compras)
        {
            Console.WriteLine(compra);
        }
    }
}
