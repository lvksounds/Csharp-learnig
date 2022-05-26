using System;

namespace TesteWhile
{
    class Program
    {
        static void Main()
        {
            // break
            /*
            while (true)
            {
                int num;
                Console.WriteLine("Digite numeros, para sair digite 10");
                num = int.Parse(Console.ReadLine());
                if (num == 10)
                {
                    Console.WriteLine("Saiu");
                    break;
                } else
                {
                    Console.WriteLine("Numero digitado: {0}", num);
                }
            }
            Console.WriteLine("Fim do loop");
            */

            // continue 
            // programa le numeros entre 10 e 20
            // caso usuario digite um numero fora do requisito, nao exibe o numero mas continua o loop

            int numero;
            while (true)
            {
                Console.WriteLine("Digite um numero entre 10 e 20");
                numero = int.Parse(Console.ReadLine());
                if (numero <= 20 && numero >= 10)
                {
                    Console.WriteLine("Numero digitado: {0}", numero);
                } else
                {
                    Console.WriteLine("Numero fora da faixa requisitada.");
                    continue;
                }
            }
        }

    }
}