using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv2
{
    internal class Solicitacao
    {
        public string nome;

        public void ExibirSolicitacao()
        {
            Console.WriteLine("Olá, " + nome + "!");
        }
    }
}
