using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProj1
{
    public class calcs
    {
        public static int Soma(int num1, int num2)
        {
            int soma = num1 + num2;
            return soma;
        }

        public static double Div(double num1, double num2)
        {
            double div = num1 / num2;
            return div;
        }

        public static long Multi(int num1, int num2)
        {
            
            return (Math.BigMul(num1, num2));
        }

        public static double Sub(double num1, double num2)
        {
            double sub = num1 - num2;
            return sub;
        }
        public static double Pot(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
