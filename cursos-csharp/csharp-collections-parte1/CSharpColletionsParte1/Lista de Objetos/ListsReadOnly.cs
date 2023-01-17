using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1.Lista_de_Objetos
{
	class ListsReadOnly
	{
		public static void TrabalhandoListsReadOnly()
		{
			Curso csharpColecoes = new Curso("C# Colletions", "Marcelo");
			csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 20));

			Console.WriteLine("---------------- LIST READ ONLY -----------------");
			ImprimirListsReadOnly(csharpColecoes.Aulas);

			//adiciona 2 aulas
			csharpColecoes.Adiciona(new Aula("Criando uma Aula", 10));
			csharpColecoes.Adiciona(new Aula("Modelando com Colecoes", 15));

			Console.WriteLine("---------------- ADICIONA AULAS -----------------");
			ImprimirListsReadOnly(csharpColecoes.Aulas);

			//csharpColecoes.Aulas.Sort(); //IList nao possui o metodo Sort

			Console.WriteLine("---------------- SORT -----------------");
			List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
			aulasCopiadas.Sort();
			ImprimirListsReadOnly(aulasCopiadas);

			Console.WriteLine("---------------- TOTALIZADOR TIME -----------------");
			Console.WriteLine(csharpColecoes.TempoTotal);

			Console.WriteLine("---------------- CURSO -----------------");
			Console.WriteLine(csharpColecoes);
		}

		private static void ImprimirListsReadOnly(IList<Aula> aulas)
		{
			foreach (var aula in aulas)
			{
				Console.WriteLine(aula);
			}
		}
	}
}
