using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1
{
	class Arrays
	{
		public static void TrabalhandoArrays()
		{
			string aulaIntro = "Introdução às Coleções";
			string aulaModelando = "Modelando a Classe Aula";
			string aulaSets = "Trabalhando com Conjuntos";

			//primeira forma de declarar um array
			//string[] aulas = new string[] { 
			//	aulaIntro,
			//	aulaModelando,
			//	aulaSets
			//};

			//segunda forma de declarar um array
			string[] aulas = new string[3];

			//atribuindo valores no array
			aulas[0] = aulaIntro;
			aulas[1] = aulaModelando;
			aulas[2] = aulaSets;

			Console.WriteLine("---------------- ARRAYS -----------------");
			ImprimirArray(aulas);

			//Reverse ele inverte os elementos do array (os primeiros virao os ultimos e os ultimos os primeiros)
			Array.Reverse(aulas);

			Console.WriteLine("---------------- REVERSE -----------------");
			ImprimirArray(aulas);

			//Resize redimensiona o tamanho de um array
			Array.Resize(ref aulas, 4);

			aulas[3] = aulaModelando;
			Console.WriteLine("---------------- RESIZE -----------------");
			Console.WriteLine($"Aula modelando esta no indice {Array.IndexOf(aulas, aulaModelando)}");
			Console.WriteLine($"A ultima ocorrencia de aula modelando esta no indice {Array.LastIndexOf(aulas, aulaModelando)}");

			Array.Resize(ref aulas, 3);
			aulas[aulas.Length - 1] = "Conclusao"; //pega a ultima posicao do array

			string[] copia = new string[2];

			Array.Copy(aulas, 1, copia, 0, 2); //copia um array para o outro
			Console.WriteLine("---------------- ARRAY COPIA -----------------");
			ImprimirArray(copia);

			string[] clone = aulas.Clone() as string[]; //clona um array
			Console.WriteLine("---------------- ARRAY CLONE -----------------");
			ImprimirArray(clone);

			Array.Sort(aulas); //ordena um array
			Console.WriteLine("---------------- AULAS SORT -----------------");
			ImprimirArray(aulas);

			Console.WriteLine("---------------- AULAS CLEAR -----------------");
			Array.Clear(clone, 1, 2);//limpa um array
			ImprimirArray(clone);
		}
		private static void ImprimirArray(string[] aulas)
		{
			//foreach (var aula in aulas)
			//{
			//	Console.WriteLine(aula);
			//}

			for (int i = 0; i < aulas.Length; i++)
			{
				Console.WriteLine(aulas[i]);
			}
		}
	}
}
