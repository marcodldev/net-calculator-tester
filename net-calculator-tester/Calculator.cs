using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Addizione(float num1, float num2)
        {
            float risultato = num1 + num2;

            return risultato;
        }

        public static float Sottrazione(float num1, float num2)
        {
            float risultato = num1 - num2;

            return risultato;
        }

        public static float Divisione(float num1, float num2)
        {
            float risultato = num1 / num2;

            return risultato;
        }

        public static float Moltiplicazione(float num1, float num2)
        {
            float risultato = num1 * num2;

            return risultato;
        }
    }
}
