using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Fixação_4
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double Converter_Dolar(double R, double cotacao)
        {
            double dolar = R * cotacao;
            return dolar + ((dolar * IOF) / 100);
        }
    }
}
