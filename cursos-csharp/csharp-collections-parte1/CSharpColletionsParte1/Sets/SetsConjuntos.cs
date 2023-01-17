using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1
{
	class SetsConjuntos
	{
		public static void TrabalhandoSetsConjuntos()
		{
			//SETS = CONJUNTOS

			//Duas propriedades do Set
			//1. Nao permite duplicidade
			//2. Os elementos nao sao mantidos em ordem especifica
			Console.WriteLine("---------------- SETS -----------------");

			ISet<String> alunos = new HashSet<string>();

			alunos.Add("Vanessa Tonini");
			alunos.Add("Ana Losnak");
			alunos.Add("Rafael Nercessian");
						
			Console.WriteLine(string.Join(",", alunos));

			alunos.Add("Priscila Stuani");
			alunos.Add("Rafel Rollo");
			alunos.Add("Fabio Gushinken");

			Console.WriteLine(string.Join(",", alunos));

			Console.WriteLine("---------------- REMOVENDO ANA -----------------");
			alunos.Remove("Ana Losnak");
			alunos.Add("Marcelo Oliveira");
			Console.WriteLine(string.Join(",", alunos));

			Console.WriteLine("---------------- ADICIONANDO O MESMO ELEMENTO -----------------");
			alunos.Add("Fabio Gushinken");
			Console.WriteLine(string.Join(",", alunos));

			//Qual a vantagem do set sobre a lista?? look-up, ou seja, mais facil buscar elementos
			//Desempenho HashSet e mais escalavel que a List, buscar elemento consegue um tempo igual indepente da qnt de elementos
			//Ja na List, esse tempo aumenta pois e necessario percorrer a List para identificar um elemento
			//Em compensacao, o HashSet ocupa mais memoria que o List
			Console.WriteLine("---------------- SORT -----------------");
			List<string> alunosEmLista = new List<string>(alunos);
			alunosEmLista.Sort();
			Console.WriteLine(string.Join(",", alunosEmLista));
		}
	}
}
