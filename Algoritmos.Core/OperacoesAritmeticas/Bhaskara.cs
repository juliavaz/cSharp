using System;
using System.Text;

namespace Algoritmos.Core.OperacoesAritmeticas
{
    public class Bhaskara
    {
        StringBuilder result = new StringBuilder();

        public string FormulaDeBhaskara(int op, int a, int b, int c)
        {
            //x = – b ± √b^2-4.a.c / 2.a
            switch (op)
            {
                case 1:
                    var resultadoPositivo = positivo(a,b,c);
                    return resultadoPositivo;
                case 2:
                    var resultadoNegativo = negativo(a,b,c);
                    return resultadoNegativo;
                case 3:
                    var resultadoPositivoEnegativo = positivoEnegativo(a,b,c);
                    return resultadoPositivoEnegativo;
                default:
                    Console.WriteLine("escolha uma aternativa");
                    break;
            }

            return result.ToString();
        }

        public string positivo(int a, int b, int c)
        {
            var delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            var formulaPositiva = (-b + Math.Sqrt(delta)) / (2.0 * a);

            result.AppendLine();
            result.Append($"--> Valor de Delta: {delta}");
            result.AppendLine();
            result.Append($"--> Resultado da Equação: {formulaPositiva}");

            return result.ToString();
        }
        public string negativo(int a, int b, int c)
        {
            var delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            var formulaNegativa = (-b - Math.Sqrt(delta)) / (2.0 * a);

            result.AppendLine();
            result.Append($"--> Valor de Delta: {delta}");
            result.AppendLine();
            result.Append($"--> Resultado da Equação: {formulaNegativa}");

            return result.ToString();
        }
        public string positivoEnegativo(int a, int b, int c)
        {
            var delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            var formulaPositiva = (-b + Math.Sqrt(delta)) / (2.0 * a);
            var formulaNegativa = (-b - Math.Sqrt(delta)) / (2.0 * a);

            result.AppendLine();
            result.Append($"--> Valor de Delta: {delta}");
            result.AppendLine();
            result.Append($"--> Resultado 'Positivo': {formulaPositiva}"); 
            result.AppendLine();
            result.Append($"--> Resultado 'Negativo': {formulaNegativa}");

            return result.ToString();
        }
    }
}
