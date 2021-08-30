using System;

namespace Questão4
{
    class Pessoa
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            string[] cargo = new string[5];

            int contador = 0;

            int starter = 0;
            int junior = 0;
            int senior = 0;

            while (contador <= 4)
            {


                Console.WriteLine("Controle de funcionários");
                Console.Write("Nome do participante pessoa: ");
                nome[contador] = Console.ReadLine();
                Console.Write("Informe o cargo do participante pessoa (starter, junior ou senior) :");
                cargo[contador] = Console.ReadLine();

                if (cargo[contador] == "starter")
                {
                    starter++;
                }
                else if (cargo[contador] == "junior")
                {
                    junior++;
                }
                else if (cargo[contador] == "senior")
                {
                    senior++;
                }
                else
                {
                    senior++;
                }

                contador++;
            }

            Console.WriteLine("Total de pessoas");

            Console.WriteLine("Starter =" + starter);
            Console.WriteLine("Junior =" + junior);
            Console.WriteLine("Senior =" + senior);

            Console.ReadLine();

        }
    }
}

