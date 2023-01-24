using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpColletionsParte1.Models;

namespace CSharpColletionsParte2.SortedSets
{
	class SortedSet
	{
		public static void TrabalhandoSortedSet()
		{
			Console.WriteLine("-------------------- HASH SET --------------------");
			//vamos criar um dicionario de alunos
			ISet<string> alunos = new HashSet<string>()
			{
				"Vanessa Tonini",
				"Ana Losnak",
				"Rafael Nercessian",
				"Priscila Stuani"
			};

			alunos.Add("Rafael Rollo");
			alunos.Add("Fabio Gushiken");
			alunos.Add("Fabio Gushiken"); //nao e inserido elemento duplicado e nao e apresentado erro
			alunos.Add("Fabio GUSHIKEN");

			Imprimindo(alunos);

			Console.WriteLine("-------------------- SORTED SET --------------------");

			ISet<string> alunosSet = new SortedSet<string>(new ComparadorMinusculo())
			{
				"Vanessa Tonini",
				"Ana Losnak",
				"Rafael Nercessian",
				"Priscila Stuani"
			};
			//SortedSet funciona como uma arvore binaria semelhante ao Sorted Dictionary

			alunosSet.Add("Rafael Rollo");
			alunosSet.Add("Fabio Gushiken");
			alunosSet.Add("Fabio Gushiken"); //nao e inserido elemento duplicado e nao e apresentado erro
			alunosSet.Add("Fabio GUSHIKEN");

			Imprimindo(alunosSet);

			ISet<string> outroConjunto = new HashSet<string>();

			//este conjunto é subconjunto de outro? IsSubsetOf
			alunos.IsSubsetOf(outroConjunto);

			//este conjunto é superconjunto de outro? IsSupersetOf
			alunos.IsSupersetOf(outroConjunto);

			//os conjuntos contêm os mesmo elementos? SetEquals
			alunos.SetEquals(outroConjunto);

			//subtrai os elementos da outra coleção que também estão nesse? ExceptWith
			alunos.ExceptWith(outroConjunto);

			//intersecção dos conjuntos - IntersectWith
			alunos.IntersectWith(outroConjunto);

			//somente em um ou outro conjunto - SymmetricExceptWith
			alunos.SymmetricExceptWith(outroConjunto);

			//união de conjuntos - UnionWith
			alunos.UnionWith(outroConjunto);
		}
		private static void Imprimindo(ISet<string> alunos)
		{
			foreach (var aluno in alunos)
			{
				Console.WriteLine(aluno);
			}
		}
	}
}
