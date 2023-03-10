using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bebidas;

namespace Bebidas
{
    abstract class Bebida
    {
        public int Id { get; set; }
        public string NomeTipo { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }

        public Bebida()
        {

        }
        public abstract Bebida(int id, string nomeTipo, decimal miliLitro, string nomeBebida,decimal valorCompra)
        {
            Id= id;
            NomeTipo= nomeTipo;
            MiliLitro= miliLitro;
            NomeBebida= nomeBebida;
            ValorCompra= valorCompra;
        }

            public void Comprar(int id, decimal valorCompra)
        {
            Console.WriteLine($"Valor da compra do produto id {id} alterado para {valorCompra}");
        }
        
    }

}
