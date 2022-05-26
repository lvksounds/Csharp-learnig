using System; 

namespace CalcProj1
{
    class Program
    {
        static void Main()
        {
            int num1, num2;
            string choose = "";

            while(choose != "0")
            {
                Console.WriteLine("Calculadora de dois digitos");
                Console.WriteLine("Digite o número da operação a ser executada.");
                Console.WriteLine("1. Adição - 2. Subtração - 3. Multiplicação - 4. Divisão. 5. Potênciação (1° valor ^ 2° valor) - 0. Encerrar.");
                choose = Console.ReadLine();

                Console.WriteLine("1° valor: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2° valor: ");
                num2 = int.Parse(Console.ReadLine());

                

                if (choose == "1")
                {
                    Console.WriteLine("Resultado: " + calcs.Soma(num1, num2));
                }
                else if (choose == "2")
                {
                    Console.WriteLine("Resultado: " + calcs.Sub(num1, num2));
                }
                else if (choose == "3")
                {
                    Console.WriteLine("Resultado: " + calcs.Multi(num1, num2));
                }
                else if (choose == "4")
                {
                    Console.WriteLine("Resultado: " + calcs.Div(Convert.ToDouble(num1), Convert.ToDouble(num2)));
                }
                else if (choose == "5")
                {
                    Console.WriteLine("Resultado: " + calcs.Pot(Convert.ToDouble(num1), Convert.ToDouble(num2)));    
                } 

                else if (choose == "0")
                {
                    Console.WriteLine("Encerrando Calculadora");
                    break;
                }
            }

            
        }
    }
}