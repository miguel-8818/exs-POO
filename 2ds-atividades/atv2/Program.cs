using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solicitacao nome = new Solicitacao();

            Console.WriteLine("Digite seu Nome: ");
            nome.nome = Console.ReadLine();

            nome.ExibirSolicitacao();
        }
    }
}
