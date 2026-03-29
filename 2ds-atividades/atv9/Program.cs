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
            leitor.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá " + leitor.nome() + " " + "Sua idade é: " + leitor.idade() + "!");
            Console.ReadLine();
        }
    }
}
