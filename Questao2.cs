using System;

namespace Questão2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor digite um número :");
            int numero = int.Parse(Console.ReadLine());

            int div3 = 0;
            int div6 = 0;
            int div7 = 0;

            if (numero % 3 == 0)
            {
                div3++;
            }
            else if (numero % 6 == 0)
            {
                div6++;
            }
            else if (numero % 7 == 0)
            {
                div7++;
            }

            if (div3 == 0 && div6 == 0 && div7 == 0)
            {
                Console.WriteLine("O número é divisivel por 3,6 e 7");
            }
            else if (div3 == 0 && div6 == 0)
            {
                Console.WriteLine("O número é divisivel por 3 e 6");
            }
            else if (div3 == 0 && div7 == 0)
            {
                Console.WriteLine("O número pe divisivel por 3 e 7");
            }
            else if (div3 == 0)
            {
                Console.WriteLine("O número é divisivel por 3");
            }
        }


        }
    }

