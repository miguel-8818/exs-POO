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

            Console.Write("Digite a Temperatura em Celsius: ");
            graus.Celsius = Convert.ToDouble(Console.ReadLine());

            double resultado = graus.Converter();

            Console.WriteLine("Temperatura em Fahrenheit: " + resultado);
            Console.ReadLine();
        }
    }
}
