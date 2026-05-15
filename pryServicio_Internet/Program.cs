using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryServicio_Internet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hogar Casa = new Hogar();

            Console.WriteLine("Nombre del cliente:");
            Casa.cliente = Console.ReadLine();
            Console.WriteLine("velocidad del internet:");
            Casa.velocidad = float.Parse(Console.ReadLine());

            Casa.CalcularCostoBase();
            Casa.CalcularImpuesto();
            Casa.CalcularCostoFinal();

            Console.WriteLine($"\nCliente:\t{Casa.cliente}");
            Console.WriteLine($"Costo Base:\t{Casa.costoBase}");
            Console.WriteLine($"Impuesto:\t{Casa.impuesto}");
            Console.WriteLine($"Costo Final:\t{Casa.costoFinal}\n");

            Empresarial empresa = new Empresarial();
            Console.WriteLine("Nombre del cliente:");
            empresa.cliente = Console.ReadLine();
            Console.WriteLine("velocidad del internet:");
            empresa.velocidad = float.Parse(Console.ReadLine());
            Console.WriteLine("Costo de soporte:");
            empresa.soporte = float.Parse(Console.ReadLine());

            empresa.CalcularCostoBase();
            empresa.CalcularImpuesto();
            empresa.CalcularCostoFinal();

            Console.WriteLine($"\nCliente:\t{empresa.cliente}");
            Console.WriteLine($"Costo Base:\t{empresa.costoBase}");
            Console.WriteLine($"Impuesto:\t{empresa.impuesto}");
            Console.WriteLine($"Costo Final:\t{empresa.costoFinal}");
        }
    }
}
