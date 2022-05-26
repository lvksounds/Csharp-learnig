using System;

namespace ModificadorStatic
{
    class Program
    {
        static void Main(string[] args)
        { 
            // quando o metodo é estatico conseguimos acessa-lo apenas chamando o nome da classe; 
            Animal.Mensagem();
            double Pi = Math.PI;

            Console.WriteLine(Pi.ToString());
        }
    }
}