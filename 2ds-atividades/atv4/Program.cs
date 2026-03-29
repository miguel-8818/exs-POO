using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boletim media = new Boletim(); 

            Console.Write("Digite a Primeira Nota: ");
            media.num1 = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Digite a Segunda Nota: ");
            media.num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Terceira Nota: ");
            media.num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Média: " + media.CalcularMedia()); 
            Console.ReadLine();

            Console.WriteLine(media.VerificarAprovacao()); 
            Console.ReadLine();
        }
    }
}
