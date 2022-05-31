using System; 

namespace CamposCompartilhadosClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // criar dois objetos do tipo acumula.
            Acumula obj1 = new Acumula();
            Acumula obj2 = new Acumula();

            obj1.incrementa();
            Console.WriteLine("O valor é {0}", Acumula.soma.ToString());
            obj1.incrementa();
            Console.WriteLine("O valor é {0}", Acumula.soma.ToString());
            obj1.incrementa(20);
            Console.WriteLine("O valor é {0}", Acumula.soma.ToString());

            obj2.incrementa(10);
            Console.WriteLine("O valor é {0}", Acumula.soma.ToString());

        }
    }
}