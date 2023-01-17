using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1
{
	class Lists
	{
		public static void TrabalhandoLists()
		{
			string aulaIntro = "Introdução às Coleções";
			string aulaModelando = "Modelando a Classe Aula";
			string aulaSets = "Trabalhando com Conjuntos";

			//primeira forma de declara uma lista (array dimanimo)
			//List<string> aulas = new List<string>
			//{
			//	aulaIntro,
			//	aulaModelando,
			//	aulaSets
			//};

			//segunda forma de declarar uma lista (array dimanimo)
			List<string> aulas = new List<string>();
			aulas.Add(aulaIntro); //adiciona um elemento na lista
			aulas.Add(aulaModelando);
			aulas.Add(aulaSets);

			Console.WriteLine("---------------- LISTS -----------------");
			ImprimirList(aulas);

			Console.WriteLine($"A primeira aula e {aulas[0]}");
			Console.WriteLine($"A primeira aula e {aulas.First()}");

			Console.WriteLine($"A ultima aula e {aulas[aulas.Count - 1]}");
			Console.WriteLine($"A ultima aula e {aulas.Last()}");

			aulas[0] = "Trabalhando com Listas";

			Console.WriteLine($"A primeira aula 'Trabalhando' e : {aulas.First((aula) => aula.Contains("Trabalhando"))}");
			Console.WriteLine($"A ultima aula 'Trabalhando' e : {aulas.Last((aula) => aula.Contains("Trabalhando"))}");
			//FirstOrDefault serve para evitar que ao nao encontrar a informacao nao de erro e sim exibe um valor em branco
			Console.WriteLine($"A primeira aula 'Conclusao' e : {aulas.FirstOrDefault((aula) => aula.Contains("Conclusao"))}");

			Console.WriteLine("---------------- 1 REVERSE -----------------");
			aulas.Reverse(); //Reverse ele inverte os elementos do array (os primeiros virao os ultimos e os ultimos os primeiros)
			ImprimirList(aulas);
			Console.WriteLine("---------------- 2 REVERSE -----------------");
			aulas.Reverse();
			ImprimirList(aulas);

			Console.WriteLine("---------------- REMOVE -----------------");
			aulas.RemoveAt(aulas.Count - 1); //remote um elemento do array pelo indice
			ImprimirList(aulas);

			Console.WriteLine("---------------- ADD E SORT -----------------");
			aulas.Add("Conclusao");
			aulas.Sort(); //orderna a lista
			ImprimirList(aulas);

			Console.WriteLine("---------------- COPIA -----------------");
			List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
			ImprimirList(copia);

			Console.WriteLine("---------------- CLONE -----------------");
			List<string> clone = new List<string>(aulas); //clonando array
			ImprimirList(clone);

			Console.WriteLine("---------------- REMOVE RANGE -----------------");
			clone.RemoveRange(clone.Count - 2, 2); //remove as 2 ultimas posicoes
			ImprimirList(clone);
		}
		private static void ImprimirList(List<string> aulas)
		{
			//foreach (var aula in aulas)
			//{
			//	Console.WriteLine(aula);
			//}

			//for (int i = 0; i < aulas.Count; i++)
			//{
			//	Console.WriteLine(aulas[i]);
			//}

			aulas.ForEach((aula) => { Console.WriteLine(aula); }); //Operacao lambda
		}
	}
}
