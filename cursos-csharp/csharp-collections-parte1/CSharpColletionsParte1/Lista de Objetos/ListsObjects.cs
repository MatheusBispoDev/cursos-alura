using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1.Lista_de_Objetos
{
	class ListsObjects
	{
		public static void TrabalhandoListsObjects()
		{
			var aulaIntro = new Aula("Introducao as Colecoes", 20);
			var aulaModelando = new Aula("Trabalhando com Conjuntos", 18);
			var aulaSets = new Aula("Modelando a Classe Aula", 16);

			List<Aula> aulas = new List<Aula>();
			aulas.Add(aulaIntro);
			aulas.Add(aulaModelando);
			aulas.Add(aulaSets);
			//aulas.Add("Conclusao"); //nao e uma operacao valida pq a lista e de objetos da classe Aula e nao string

			Console.WriteLine("---------------- LISTS OBJECTS -----------------");
			ImprimirListsObjects(aulas);

			Console.WriteLine("---------------- SORT -----------------");
			aulas.Sort();
			ImprimirListsObjects(aulas);

			Console.WriteLine("---------------- SORT TIME -----------------");
			aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
			ImprimirListsObjects(aulas);
		}

		private static void ImprimirListsObjects(List<Aula> aulas)
		{
			aulas.ForEach((aula) => Console.WriteLine(aula));
		}
	}
}
