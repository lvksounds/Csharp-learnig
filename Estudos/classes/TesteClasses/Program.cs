using System; 

namespace TesteClasses
{
    class Program
    {
        static void Main()
        {
            Caixa cx;
            cx = new Caixa(8);

            double volumeCaixa = cx.Volume();

            Console.WriteLine(volumeCaixa.ToString());
            Console.WriteLine(Caixa.CaixaLadoDois()); // acessando o metodo estatico CaixaLadoDois, que nao tem necessidade de ser instanciado. 
        }
    }
}