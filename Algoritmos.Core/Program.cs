using Algoritmos.Core;
using Algoritmos.Core.OperacoesAritmeticas;
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

            var opcaoSelecionada = 1;
            while (opcaoSelecionada != 0)
            {
                Console.Write("\n----------------------------------------");
                Console.Write("\nDigite uma opção disponível no MENU: ");
                Console.WriteLine("\n[ ----- MENU ----- ]");            
                foreach (var item in dicMenu)
                {
                    var itemMenu = item.Value;
                    Console.WriteLine($"[{item.Key}] - {itemMenu.Descricao}");
                }

                opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

                if (dicMenu.ContainsKey(opcaoSelecionada))
                {
                    dicMenu[opcaoSelecionada].Operacao.Invoke();
                }
                else
                {
                    Console.WriteLine("\n[!] Opção inválida. Tente novamente");
                    Thread.Sleep(1000);
                }
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
            dicMenu.Add(6, new ItemMenu("Fórmula de Bhaskara", ExecutarFormulaDeBhaskara));
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

        public static void ExecutarFormulaDeBhaskara()
        {
            Console.WriteLine("\n-> Você selecionou 'Fórmula de Bhaskara'");
            Thread.Sleep(1000);

            Console.Write("Escolha a opção para realizar o calculo: \n");
            Console.Write("[ 1 ] - Resultado positivo \n");
            Console.Write("[ 2 ] - Resultado negativo \n");
            Console.Write("[ 3 ] - Resultado positivo e negativo \n");
            int op = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Bhaskara bhaskara = new Bhaskara();
            var resultado = bhaskara.FormulaDeBhaskara(op,a,b,c);
            Console.WriteLine($"{resultado}");
        }
    }
}