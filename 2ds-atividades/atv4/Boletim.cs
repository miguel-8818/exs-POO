using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4
{
    internal class Boletim
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double num3 { get; set; }
        public string aluno;
        public double CalcularMedia()
        {
            return (num1 + num2 + num3) / 3;
        }

        public string VerificarAprovacao()
        {
            if (CalcularMedia() >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
