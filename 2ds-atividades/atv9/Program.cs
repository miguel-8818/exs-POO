using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leitor leitor = new Leitor();

            Console.Write("Digite seu nome: ");
            leitor.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            leitor.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(leitor.Mensagem());
        }
    }
}
