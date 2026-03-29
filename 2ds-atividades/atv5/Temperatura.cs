using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
{
    internal class Temperatura
    {
        public double Celsius;
        public string graus;

        public double Converter()
        {
            return Celsius * 9 / 5 + 32;
        }
    }
}
