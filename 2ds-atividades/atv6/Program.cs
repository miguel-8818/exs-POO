using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dobrar numero = new Dobrar();

            Console.Write("Digite um número: ");
            numero.Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O dobro é: " + numero.Dobro());
            Console.ReadLine();
        }
    }
}
