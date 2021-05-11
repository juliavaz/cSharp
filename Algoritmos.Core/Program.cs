using Algoritmos.Core;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Algoritmos
{
    public class Algoritmos
    {
        static Dictionary<int, ItemMenu> dicMenu = new Dictionary<int, ItemMenu>();
        public static void Main(string[] args)
        {

            CriarMenu();

            Console.WriteLine("Selecione uma opção");

            foreach (var item in dicMenu)
            {
                var itemMenu = item.Value;
                Console.WriteLine($"{item.Key} - {itemMenu.Descricao}");
            }

            int opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

            if (!dicMenu.ContainsKey(opcaoSelecionada))
                Console.WriteLine("Opção inválida");

            dicMenu[opcaoSelecionada].Operacao.Invoke();


            Console.Read();

        }
        public static void CriarMenu()
        {
            dicMenu.Add(1,new ItemMenu("SOMA",ExecutarSoma));
            dicMenu.Add(2, new ItemMenu("TABUADA", ExecutarTabuada));
        }      


        //public static void Main(string[] args)
        //{
        //    string[] funcoes = {"",
        //        "Soma",
        //        "Formatando Números",
        //        "Saída de Dados",
        //        "Tabuada",
        //        "Soma Param Array"
        //    };

        //    var op = 1;
        //    while (op != 0)
        //    {
        //        Console.WriteLine("\n----------------------------------------");
        //        Console.WriteLine("! Para sair do MENU digite o número 0");
        //        Console.WriteLine("\n[ ----- MENU ----- ]");
        //        for (int i = 1; i < funcoes.Length; i++)
        //        {
        //            Console.WriteLine($"[{i}] - {funcoes[i]}");
        //        };

        //        Console.Write("\nDigite o número disponível no MENU: ");
        //        var item = Convert.ToInt32(Console.ReadLine());

        //        if (item == 0)
        //        {
        //            Console.WriteLine("\nSaindo...");
        //            Thread.Sleep(2000);
        //            Console.WriteLine("Saída executada com êxito!");
        //            break;
        //        }

        //        switch (item)
        //        {
        //            case 1:
        //                ExecutarSoma();                       
        //                break;

        //            case 2:
        //                Console.WriteLine("\n-> Você selecionou 'Formatando Números'");
        //                Thread.Sleep(1000);

        //                Console.Write("Digite o valor a ser formatado: ");
        //                double saldo = Convert.ToDouble(Console.ReadLine());
        //                FormatNumeros formatNumeros = new FormatNumeros();
        //                var resultado1 = formatNumeros.NumeroFormatado(saldo);
        //                Console.WriteLine($"{resultado1}");
        //                break;

        //            case 3:
        //                Console.WriteLine("\n-> Você selecionou 'Saída de Dados'");
        //                Thread.Sleep(1000);

        //                SaidaDados saidaDados = new SaidaDados();
        //                var resultado2 = saidaDados.SaidaDeDados();
        //                Console.WriteLine($"{resultado2}");
        //                break;

        //            case 4:
        //                Console.WriteLine("\n-> Você selecionou 'Tabuada'");
        //                Thread.Sleep(1000);

        //                Console.Write("Insira o valor da tabuada que quer saber: ");
        //                int valor = Convert.ToInt32(Console.ReadLine());
        //                Tabuada tabuada = new Tabuada();
        //                var resultado3 = tabuada.TabelaTabuada(valor);
        //                Console.WriteLine($"{resultado3}");
        //                break;

        //            case 5:
        //                Console.WriteLine("\n-> Você selecionou 'Soma Param Array'");
        //                Thread.Sleep(1000);

        //                Console.Write("Informe os números que irá somar separado por espaço: ");
        //                var itens = Console.ReadLine();
        //                var list = Array.ConvertAll(itens.Split(' '), int.Parse);

        //                SomaParamArray useParam = new SomaParamArray();
        //                var resultadoSoma = useParam.SomandoIndicesDoArray(list);
        //                Console.WriteLine($"Soma = {resultadoSoma}");
        //                break;

        //            default:
        //                Console.Write("Insira um número que está disponivel no menu\nDigite novamente o número: ");
        //                break;
        //        }
        //    }
        //}

        public static void ExecutarSoma()
        {
            Console.WriteLine("\n-> Você selecionou 'Soma'");
            Thread.Sleep(1000);

            Console.Write("Digite primeiro o numero: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite segundo o numero: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Soma somaSimples = new Soma();
            var resultado = somaSimples.SomarDoisNumeros(a, b);
            Console.WriteLine($"O resultado da soma é : {resultado}");
        }

        public static void ExecutarTabuada()
        {
            Console.WriteLine("\n-> Você selecionou 'Tabuada'");
            Thread.Sleep(1000);

            Console.Write("Insira o valor da tabuada que quer saber: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Tabuada tabuada = new Tabuada();
            var resultado3 = tabuada.TabelaTabuada(valor);
            Console.WriteLine($"{resultado3}");

        }
    }
}