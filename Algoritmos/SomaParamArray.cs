using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algoritmos
{
    public class SomaParamArray
    {
        public int SomandoIndicesDoArray(params int[] list)
        {
            return list.Sum();
        }        
    }
}
