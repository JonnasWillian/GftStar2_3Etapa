using System;

namespace Questão3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Por favor digite um número como multiplicador:");
            int multiplicador = int.Parse(Console.ReadLine());

            if (multiplicador < 1 && multiplicador >1500)
            {
                Console.WriteLine("Por favor, digite um número maior que 1 e menor que 1500");
                multiplicador = 0;
            }

            Console.Write("Por favor digite um número para iniciar a sequencia de multiplicação:");
            int inicio= int.Parse(Console.ReadLine());

            Console.Write("Por favor digite um número para finalizar a sequencia de multiplicação:");
            int fim = int.Parse(Console.ReadLine());

            if (inicio >= fim)
            {
                Console.WriteLine("O inicio do intervalo deve ser maior que o fim");
                inicio = 0;
                fim = 0;

                Console.ReadLine();
            }

            while (inicio <= fim)
            {
                int soma = multiplicador * inicio;
                Console.WriteLine(multiplicador + "X" + inicio + "=" + soma);
                inicio++;

            }
        }
    }
}
