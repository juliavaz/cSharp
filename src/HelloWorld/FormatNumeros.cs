using System;
using System.Globalization; // converte , para .

namespace Program
{
    public class FormatNumeros
    {
        public string NumeroFormatado(double saldo)
        {          
            return saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
    /** 
        * F2 - duas casas decimais
        * F3 - três casas decimais
        * F4 - etc....
        * 
        --- Tem arredondamentos!
        * 0 - 4 : para baixo
        * 5 - 9 : para cima
        * 
        --- Conversão de , (vírgula) para . (ponto)
        * CultureInfo.InvariantCulture
        * 
    **/
