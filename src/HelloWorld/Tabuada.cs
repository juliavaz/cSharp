using System;
using System.Text;

namespace Program
{
    public class Tabuada
    {
        public string TabelaTabuada(int valor)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= 10; i++)
            {
                var calculo = $"{valor} X {i} = {valor*i}";
                result.Append(calculo);
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }
    }
}
