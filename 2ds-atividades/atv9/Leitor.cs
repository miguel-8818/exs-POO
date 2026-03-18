using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv9
{
    internal class Leitor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Mensagem()
        {
            return $"Bem-vindo, {Nome}! Você tem {Idade} anos!.";
        }

    }
}
