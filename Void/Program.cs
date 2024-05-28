using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da soma é: " + soma(n1, n2));

            Console.ReadKey();
        }
        static double soma (double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
