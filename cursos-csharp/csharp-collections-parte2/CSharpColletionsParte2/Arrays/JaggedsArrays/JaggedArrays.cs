using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte2.JaggedsArrays
{
	class JaggedArrays
	{
		public static void TrabalhandoArrayJaggedArrays()
		{
			Console.WriteLine("-------------------- JAGGED ARRAYS --------------------");

			//array denteado ou array serrilhado, pois as linhas possuem um numero fixo,
			//porem as colunas sao incertas, ou seja, para cada linha pode possuir n numeros de colunas
			string[][] familias = new string[3][];

			familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
			familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
			familias[2] = new string[] { "Florinda", "Kiko" };

			foreach (var familia in familias)
			{
				Console.WriteLine(string.Join(",", familia));
			}
		}
	}
}
