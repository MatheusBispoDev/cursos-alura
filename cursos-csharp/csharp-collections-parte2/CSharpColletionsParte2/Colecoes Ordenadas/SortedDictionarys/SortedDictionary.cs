using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpColletionsParte1.Models;

namespace CSharpColletionsParte2.SortedDictionarys
{
	class SortedDictionary
	{
		public static void TrabalhandoSortedDictionary()
		{
			Console.WriteLine("-------------------- DICTIONARY --------------------");
			//vamos criar um dicionario de alunos
			IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

			alunos.Add("VT", new Aluno("Vanessa", 34672));
			alunos.Add("AL", new Aluno("Ana", 5617));
			alunos.Add("RN", new Aluno("Rafael", 17645));
			alunos.Add("WM", new Aluno("Wanderson", 11287));

			ImprimindoSortedDictionary(alunos);

			//vamos remover: AL - Ana
			alunos.Remove("AL");
			//vamos adicionar: MO - Marcelo
			alunos.Add("MO", new Aluno("Marcelo", 12345));
			Console.WriteLine("-------------------- APOS ADICIONAR E REMOVER --------------------");
			ImprimindoSortedDictionary(alunos);

			//as chaves dos Dictionary sao armazenados na memoria nao e de forma ordenada, ou seja,
			//os dados nao sao inseridos sequencialmente,
			//um item inserido por ultimo pode ser listado como o primeiro (a ordenacao e feita pelo codigo hash)

			//apresentando uma nova colecao... SortedDictionary - um Dictionary ordenado
			//ele é processado internamente como uma arvore binaria,
			//a busca para insercao de um novo elemento, sempre e feita pela raiz da arvore e indo ate o 
			//proxima chave para ser incluido, ou seja, consome mais processamento, porem como nao tem
			//a necessidade de se ajustar a cada elemento incluido ou excluido, tende a ser mais rapido que a sorted list
			
			//o SortedDictionary (listas grandes) e ideal para cenarios onde e preciso incluir ou buscar muitos elementos
			//caso os elementos ja estam pre-definidos e nao sofrerao alteracoes o SortedList e o ideal

			IDictionary<string, Aluno> sortedAlunos = new SortedDictionary<string, Aluno>();

			sortedAlunos.Add("VT", new Aluno("Vanessa", 34672));
			sortedAlunos.Add("AL", new Aluno("Ana", 5617));
			sortedAlunos.Add("RN", new Aluno("Rafael", 17645));
			sortedAlunos.Add("WM", new Aluno("Wanderson", 11287));
			Console.WriteLine("-------------------- SORTED DICTIONARY --------------------");
			ImprimindoSortedDictionary(sortedAlunos);
		}

		private static void ImprimindoSortedDictionary(IDictionary<string, Aluno> alunos)
		{
			foreach (var aluno in alunos)
			{
				Console.WriteLine(aluno);
			}
		}
	}
}
