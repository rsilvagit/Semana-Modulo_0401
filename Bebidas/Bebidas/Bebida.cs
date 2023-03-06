using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Refrigerante { get; set; }
        public string Suco { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }
       
        public Bebida(int id, string refrigerate, string suco, decimal miliLitro, string nomeBebida,decimal valorCompra)
        {
            Id= id;
            Refrigerante= refrigerate;
            Suco= suco;
            MiliLitro= miliLitro;
            NomeBebida= nomeBebida;
            ValorCompra= valorCompra;
            public void Comprar()
        {
            Console.WriteLine($"Valor da compra do produto id {id} alterado para {valorCompra}");
        }
        }
        

    }

}
