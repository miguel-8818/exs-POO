using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem mensagem = new Mensagem();
            mensagem.msg = "Olá, Mundo!";
            mensagem.ExibirMensagem();
        }
    }
}
