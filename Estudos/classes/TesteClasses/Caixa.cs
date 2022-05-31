using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasses
{
    class Caixa
    {
        private double lado;

        public Caixa()
        {
            lado = 10;
        }

        public Caixa(double side) // sobrecarga do metodo construtor Caixa
        {
            lado = side;
        }

        public double Volume()
        {
            return lado * lado * lado;
        }

        public static int CaixaLadoDois()
        {
            int lat = 2;
            int vol = lat * lat * lat;
            return vol;
        }

    }
}
