using System;
using System.Linq;

namespace Algoritmos
{
    public class Algoritmos
    {
        public static void Main(string[] args)
        {
            /**            
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

            // Soma Param Array    
            int[] list = { 1, 1, 1, 1, 6 };
            SomaParamArray useParam = new SomaParamArray();
            var resultadoSoma = useParam.SomandoIndicesDoArray(list);
            Console.WriteLine($"Soma = {resultadoSoma}");
            
            **/

            // Soma Param Array    
            
            Console.Write("Informe a quantidade de numeros que irá inserir: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[tam];
            for (int i = 0; i < tam; i++)
            {
                Console.Write($"Insira o {i+1}º número: ");
                list[i] = Convert.ToInt32(Console.ReadLine());
            }
            SomaParamArray useParam = new SomaParamArray();
            var resultadoSoma = useParam.SomandoIndicesDoArray(list);
            Console.WriteLine($"Soma = {resultadoSoma}");
        }
    }
}