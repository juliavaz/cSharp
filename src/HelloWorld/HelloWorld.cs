﻿using System;

namespace HelloWorld
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            // Soma
            Console.WriteLine("Digite primeiro o numero ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite segundo o numero ");
            double b = Convert.ToDouble(Console.ReadLine());
            Soma somaSimples = new Soma();
            var resultado = somaSimples.SomarDoisNumeros(a, b);
            Console.WriteLine($"O resultado é : {resultado}");
            Console.ReadKey();

            // Formatando Números
            Console.WriteLine("Digite o valor a ser formatado");
            double saldo = Convert.ToDouble(Console.ReadLine());
            FormatNumeros formatNumeros = new FormatNumeros();
            var resultado1 = formatNumeros.NumeroFormatado(saldo);
            Console.WriteLine($"{resultado1}");

            // Saída de Dados
            SaidaDados saidaDados = new SaidaDados();
            var resultado2 = saidaDados.SaidaDeDados();
            Console.WriteLine($"{resultado2}");
            Console.ReadKey();

            // Tabuada
            Console.WriteLine("Insira o valor da tabuada que quer saber!! ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Tabuada tabuada = new Tabuada();
            var resultado3 = tabuada.TabelaTabuada(valor);
            Console.WriteLine($"{resultado3}");

        }
    }
}
