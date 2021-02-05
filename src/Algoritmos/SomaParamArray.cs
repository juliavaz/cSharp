using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algoritmos
{
    public class SomaParamArray
    {
        public string SomandoIndicesDoArray(params int[] list)
        {
            int[] myIntArray = { 1, 1, 1, 1, 6 };
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < list.Length; i++)
            {
                result.Append($"{list[i]}");
            }

            var soma = myIntArray.Sum();
            result.Append($"{ soma }");

            return result.ToString();
        }        
    }
}
