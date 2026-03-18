using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();

            Console.Write("Digite o valor em Dólar: ");
            conversor.Dolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor em Reais: R$ " + conversor.Converter());
        }
    }
}
