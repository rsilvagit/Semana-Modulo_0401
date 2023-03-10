using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bebidas;

namespace Bebidas
{
	public class Refirgerante : Bebida

	{
		public Vidro bool {get;set;}
		
       
	} 
	public Refrigerante(bool vidro,int id, string nomeTipo, decimal miliLitro, string nomeBebida,decimal valorCompra) base:(id,nomeTipo,,miliLitro,nomeBebida,valorCompra)
		{
			Vidro = vidro;
		}

 }

