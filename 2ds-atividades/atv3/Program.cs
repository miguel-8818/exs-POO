using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora soma = new Calculadora();

            Console.Write("Digite o primeiro número: ");
            soma.num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            soma.num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: " + soma.Calcular());
        }
    }
}
