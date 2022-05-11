using System;

namespace novosArrays
{
    class Teste
    {
        static void Main()
        {
            //declarando um array
            // delcaração tradicional

            int[] array = new int[10];

            //inserindo dados no array: 
            // formas tradicionais
            // primeira forma: declaração explicita do tamanho do array
            int[] array2 = new int[5] {1, 2, 3, 4, 5};

            //segunda maneira, forma implicita quanto ao tamanho 
            int[] array3 = { 1, 2, 4, 5, 6 };
            

            // inserindo dados a partir do acesso ao indice do item
            for (int i = 0; i < 10; i++)
            {
                array[i] = i + 1;
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(array[9]);

            string[] alunos = new string[5] { "Lucas Oliveira", "Sarah Carla Souza", "Matthew Almeida", "Matheus Motta", "Gustavo Guarnieri" };

            alunos[4] = "João Guilherme";

            foreach (string i  in alunos)
            {
                Console.WriteLine(i);
            }
        }
    }
}