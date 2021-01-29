using System;

namespace SomaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, soma;
            Console.WriteLine("Para sair do loop digite o número 0");

            while (true)
            {
                Console.Write("Insira o primeiro valor: ");
                a = float.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Saindo do loop");
                    break;
                }

                Console.Write("Insira o segundo valor: ");
                b = float.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("Saindo do loop");
                    break;
                }

                soma = a + b;

                Console.WriteLine("SOMA = " + soma);
            }
        }
    }
}
