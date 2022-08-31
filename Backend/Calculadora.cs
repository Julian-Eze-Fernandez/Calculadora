using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Calculadora
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Res { get; set; }

        public double Operar(string operacion)
        {
            if (operacion == "+")
            {
                Res = Num1 + Num2;
                return Res;
            }
            else if (operacion == "-")
            {
                Res = Num1 - Num2;
                return Res;
            }
            else if (operacion == "*")
            {
                Res = Num1 * Num2;
                return Res;
            }
            else if (operacion == "/")
            {
                Res = Num1 / Num2;
                return Res;
            }
            else
            {
                return 0;
            }

        }

    }
}
