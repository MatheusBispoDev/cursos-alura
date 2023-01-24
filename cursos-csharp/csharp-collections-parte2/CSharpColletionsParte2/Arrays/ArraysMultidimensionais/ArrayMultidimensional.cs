using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte2.ArraysMultidimensionais
{
	class ArrayMultidimensional
	{
		public static void TrabalhandoArrayMultidimensional()
		{
			Console.WriteLine("-------------------- ARRAYS MULTIDIMENSIONAIS --------------------");
			string[,] selecoes = new string[4, 3];
			//{
			//	{ "Alemanha", "Espanha", "Italia", },
			//	{ "Argentina", "Holanda", "Franca",},
			//	{ "Holanda", "Alemanha", "Alemanha" }
			//};

			selecoes[0, 0] = "Alemanha";
			selecoes[1, 0] = "Argentina";
			selecoes[2, 0] = "Holanda";
			selecoes[3, 0] = "Brasil";

			selecoes[0, 1] = "Espanha";
			selecoes[1, 1] = "Holanda";
			selecoes[2, 1] = "Alemanha";
			selecoes[3, 1] = "Urugai";

			selecoes[0, 2] = "Itália";
			selecoes[1, 2] = "França";
			selecoes[2, 2] = "Alemanha";
			selecoes[3, 2] = "Portugal";

			for (int copa = 0; copa <= selecoes.GetUpperBound(1); copa++)
			{
				int ano = 2014 - copa * 4;
				Console.Write(ano.ToString().PadRight(12));
			}
			Console.WriteLine();

			//GetUpperBound(indice) -> indice = 0 faz referencia as linhas do array [linhas, colunas]
			//GetUpperBound(indice) -> indice = 1 faz referencia as colunas do array [linhas, colunas]
			for (int posicao = 0; posicao <= selecoes.GetUpperBound(0); posicao++)
			{
				for (int copa = 0; copa <= selecoes.GetUpperBound(1); copa++)
				{
					Console.Write(selecoes[posicao, copa].PadRight(12));
				}
				Console.WriteLine();
			}


			//Imprimindo(selecoes);
		}
		private static void Imprimindo(string[,] selecoes)
		{
			foreach (var selecao in selecoes)
			{
				Console.WriteLine(selecao);
			}
		}
	}
}
