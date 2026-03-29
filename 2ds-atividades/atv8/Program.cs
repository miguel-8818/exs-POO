using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Antecessor_Sucessor valor = new Antecessor_Sucessor();

            Console.Write("Digite um número inteiro: ");
            valor.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Antecessor: " + valor.Antecessor());
            Console.ReadLine();

            Console.WriteLine("Sucessor: " + valor.Sucessor());
            Console.ReadLine();
        }
    }
}
