using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv8
{
    internal class Antecessor_Sucessor
    {
        public int Numero { get; set; }
        public string valor;

        public int Antecessor()
        {
            return Numero - 1;
        }
        public int Sucessor()
        {
            return Numero + 1;
        }
    }
}
