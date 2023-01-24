using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpColletionsParte2.Models;

namespace CSharpColletionsParte2.LinQs
{
	class OperadoresLinq
	{
		public static void OutrosOperadoresLinq()
		{
			Console.WriteLine("-------------------- OUTROS OPERADORES LINQ --------------------");
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

            //pegar o primeiro trimestre dos meses
            //Take() -> Pega os 3 primeiros elementos da consulta
            Console.WriteLine("-------------------- LINQ - TAKE() --------------------");
            var consulta = meses.Take(3);
			foreach (var mes in consulta)
			{
				Console.WriteLine(mes);
			}

            Console.WriteLine("-------------------- LINQ - SKIP() --------------------");
            //Pegar os meses depois do primeiro trimestre
            var consulta2 = meses.Skip(3);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }           

            Console.WriteLine("-------------------- LINQ - SKIP() E TAKE() --------------------");
            //Pegar os meses do terceiro trimestre
            var consulta3 = meses.Skip(6).Take(3);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            };

            Console.WriteLine("-------------------- LINQ - TAKEWHILE() --------------------");
            //Pegar os meses até que o mês NAO comece com a letra 'S'
            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------- LINQ - SKIPWHILE() --------------------");
            //Pular os meses ATE que o mês comece com a letra 'S' e imprimir o restante
            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }           
        }
	}
}
