using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Core
{
    public class ItemMenu
    {     
        public string Descricao { get; set; }
        public Action Operacao { get; set; }
        public ItemMenu(string descricao, Action operacao)
        {
            Descricao = descricao;
            Operacao = operacao;
        }

    }
}
