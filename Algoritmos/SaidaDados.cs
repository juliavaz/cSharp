using System;
using System.Globalization;

namespace Algoritmos
{
    public class SaidaDados
    {
        public string SaidaDeDados()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'F';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            var resultado = $"Produtos: \n {produto1} , cujo preço é $ {preco1.ToString("F2")} " +
                $"\n {produto2}, cujo preço é $ {preco2.ToString("F2")} \n " +
                $"\nRegistro: {idade} anos de idade, código {codigo} e gênero {genero} \n " +
                $"\nMedida com oito casas decimais : {medida.ToString("F8")} " +
                $"\nArredondado ( Três casas decimais ): { medida.ToString("F3")} " +
                $"\nSeparador decimal InvariantCulture: {medida.ToString("F3", CultureInfo.InvariantCulture)}";

            return resultado;
        }
    }
}
