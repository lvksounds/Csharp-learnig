using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorStatic
{
    internal class Animal
    {
        private int idade = 10;
        private double peso = 50.4;

        public int ObterIdade()
        {
            return idade;   
        }

        public double Obterpeso
        {
            get { return peso; }    
        }

        public static void Mensagem()
        {
            Console.WriteLine("Metodo Estatico");
        }
    }
}
