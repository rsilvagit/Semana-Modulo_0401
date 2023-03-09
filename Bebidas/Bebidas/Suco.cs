using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bebidas;

namespace Bebidas
{
    public class Suco : Bebida
    {
       public string TipoCaixa { get; set; }
      
 
        public Suco(string tipoCaixa,int id, string nomeTipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base (id,nomeTipo,miliLitro, nomeBebida,valorCompra)
        {
            TipoCaixa= tipoCaixa;   
        }
    }


}
