using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpColletionsParte1.Models;

namespace CSharpColletionsParte2.SortedLists
{
	class SortedList
	{
		public static void TrabalhandoSortedList()
		{
			Console.WriteLine("-------------------- DICTIONARY --------------------");
			//vamos criar um dicionario de alunos
			IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

			alunos.Add("VT", new Aluno("Vanessa", 34672));
			alunos.Add("AL", new Aluno("Ana", 5617));
			alunos.Add("RN", new Aluno("Rafael", 17645));
			alunos.Add("WM", new Aluno("Wanderson", 11287));

			ImprimindoSortedList(alunos);

			//vamos remover: AL - Ana
			alunos.Remove("AL");
			//vamos adicionar: MO - Marcelo
			alunos.Add("MO", new Aluno("Marcelo", 12345));
			Console.WriteLine("-------------------- APOS ADICIONAR E REMOVER --------------------");
			ImprimindoSortedList(alunos);

			//as chaves dos Dictionary sao armazenados na memoria nao e de forma ordenada, ou seja,
			//os dados nao sao inseridos sequencialmente,
			//um item inserido por ultimo pode ser listado como o primeiro (a ordenacao e feita pelo codigo hash)

			//apresentando uma nova colecao... SortedList - um Dictionary ordenado
			//o processamento interno funciona como uma lista, o oproximo elemento que sera inserido
			//sera acrescentado no final da lista, ou seja, um processamento mais lento, pois a lista
			//tera que ser ajustada a cada insercao ou remocao de elementos

			//o SortedDictionary (listas grandes) e ideal para cenarios onde e preciso incluir ou buscar muitos elementos
			//caso os elementos ja estam pre-definidos e nao sofrerao alteracoes o SortedList e o ideal

			IDictionary<string, Aluno> sortedAlunos = new SortedList<string, Aluno>();

			sortedAlunos.Add("VT", new Aluno("Vanessa", 34672));
			sortedAlunos.Add("AL", new Aluno("Ana", 5617));
			sortedAlunos.Add("RN", new Aluno("Rafael", 17645));
			sortedAlunos.Add("WM", new Aluno("Wanderson", 11287));
			Console.WriteLine("-------------------- SORTED LIST --------------------");
			ImprimindoSortedList(sortedAlunos);
		}

		private static void ImprimindoSortedList(IDictionary<string, Aluno> alunos)
		{			
			foreach (var aluno in alunos)
			{
				Console.WriteLine(aluno);
			}
		}
	}
}
