using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpColletionsParte2.Models;

namespace CSharpColletionsParte2.LinQs
{
	class UsandoLinq
	{
		public static void TrabalhandoLinq()
		{
			Console.WriteLine("-------------------- LINQ --------------------");
            List<Mes> meses = new List<Mes>
            {
                    new Mes("Janeiro", 31),
                    new Mes("Fevereiro", 28),
                    new Mes("Março", 31),
                    new Mes("Abril", 30),
                    new Mes("Maio", 31),
                    new Mes("Junho", 30),
                    new Mes("Julho", 31),
                    new Mes("Agosto", 31),
                    new Mes("Setembro", 30),
                    new Mes("Outubro", 31),
                    new Mes("Novembro", 30),
                    new Mes("Dezembro", 31)
            };

            //meses.Sort(); //precisa implementar IComparable para usar o metodo Sort()
            //foreach (var mes in meses)
            //{
            //    if(mes.Dias == 31)
            //	{
            //        Console.WriteLine(mes.Nome.ToUpper());
            //    }                    
            //}

            //LINQ = CONSULTA INTEGRADA A LINGUAGEM
            //Com o Orderby via LINQ nao e necessario implementar o IComparable
            
            //montagem da consulta
            var consulta = meses
                .Where(where => where.Dias == 31)
                .OrderBy(order => order.Nome)
                .Select(select => select.Nome.ToUpper());

            //utilizacao da consulta
			foreach (var mes in consulta)
			{
				Console.WriteLine(mes);
			}

        }
	}
}
