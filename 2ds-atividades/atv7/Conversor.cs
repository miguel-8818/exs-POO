using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv7
{
    internal class Conversor
    {
        public double Dolar;
        public double Taxa = 5.0;

        public double Converter()
        {
            return Dolar * Taxa;
        }
    }
}
