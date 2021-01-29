using System;

namespace Exercicio02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {
            int valor, n, result;

            Console.WriteLine("Insira o valor da tabuada que quer saber!! ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                result = valor * i;
                Console.WriteLine(valor + " X " + i + " = " + result);
            }
        }
    }
}
