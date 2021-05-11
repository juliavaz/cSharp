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
            Console.Write("\nDigite uma opção disponível no MENU: ");
            CriarMenu();

            var opcaoSelecionada = 1;
            while (opcaoSelecionada != 0)
            {
                Console.WriteLine("\n! Para sair do MENU digite o número 0");
                Console.WriteLine("\n[ ----- MENU ----- ]");            
                foreach (var item in dicMenu)
                {
                    var itemMenu = item.Value;
                    Console.WriteLine($"[{item.Key}] - {itemMenu.Descricao}");
                }

                opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

                if (!dicMenu.Equals(opcaoSelecionada))
                    Console.WriteLine("Opção inválida");
                                                
                dicMenu[opcaoSelecionada].Operacao.Invoke();
                
            }
        }

        public static void CriarMenu()
        {
            dicMenu.Add(0, new ItemMenu("Sair", Sair));
            dicMenu.Add(1, new ItemMenu("Soma", ExecutarSoma));
            dicMenu.Add(2, new ItemMenu("Formatando Números", ExecutarFormatarNumeros));
            dicMenu.Add(3, new ItemMenu("Saída de Dados", ExecutarSaidaDeDados));
            dicMenu.Add(4, new ItemMenu("Tabuada", ExecutarTabuada));
            dicMenu.Add(5, new ItemMenu("Soma Param Array", ExecutarSomaParamArray));
        }      
       
        public static void Sair()
        {
            Console.WriteLine("\nSaindo...");
            Thread.Sleep(2000);
            Console.WriteLine("Saída executada com êxito!");            
        }

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

        public static void ExecutarFormatarNumeros()
        {
            Console.WriteLine("\n-> Você selecionou 'Formatando Números'");
            Thread.Sleep(1000);

            Console.Write("Digite o valor a ser formatado: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            FormatNumeros formatNumeros = new FormatNumeros();
            var resultado = formatNumeros.NumeroFormatado(saldo);
            Console.WriteLine($"{resultado}");
        }

        public static void ExecutarSaidaDeDados()
        {
            Console.WriteLine("\n-> Você selecionou 'Saída de Dados'");
            Thread.Sleep(1000);

            SaidaDados saidaDados = new SaidaDados();
            var resultado = saidaDados.SaidaDeDados();
            Console.WriteLine($"{resultado}");
        }

        public static void ExecutarTabuada()
        {
            Console.WriteLine("\n-> Você selecionou 'Tabuada'");
            Thread.Sleep(1000);

            Console.Write("Insira o valor da tabuada que quer saber: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Tabuada tabuada = new Tabuada();
            var resultado = tabuada.TabelaTabuada(valor);
            Console.WriteLine($"{resultado}");
        }

        public static void ExecutarSomaParamArray()
        {
            Console.WriteLine("\n-> Você selecionou 'Soma Param Array'");
            Thread.Sleep(1000);

            Console.Write("Informe os números que irá somar separado por espaço: ");
            var itens = Console.ReadLine();
            var list = Array.ConvertAll(itens.Split(' '), int.Parse);

            SomaParamArray useParam = new SomaParamArray();
            var resultado = useParam.SomandoIndicesDoArray(list);
            Console.WriteLine($"Soma = {resultado}");
        }
    }
}