using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_de_Acesso
{
    class animal
    {
        private int idade = 10; // variavel de acesso privado
        double peso = 50.40;

        public int ObterIdade()
        {
            return idade;
        }

        public double ObterPeso
        {
            get { return peso;  }
        }

    }
}
