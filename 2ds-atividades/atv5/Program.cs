using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura graus = new Temperatura();

            Console.Write("Digite a temperatura em Celsius: ");
            graus.Celsius = Convert.ToDouble(Console.ReadLine());

            double resultado = graus.Converter();

            Console.WriteLine("emperatura em Fahrenheit: " + resultado);
        }
    }
}
