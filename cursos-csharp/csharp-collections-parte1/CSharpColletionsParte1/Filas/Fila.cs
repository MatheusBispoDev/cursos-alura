using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1.Filas
{
	class Fila
	{
		static Queue<string> pedagio = new Queue<string>();
		public static void TrabalhandoFila()
		{
			Console.WriteLine("---------------- FILA -----------------");
			Enfileirar("van");
			Enfileirar("Kombi");
			Enfileirar("guincho");
			Enfileirar("pickup");

			MostrarFila();

			Desenfileirar();
			Desenfileirar();
			Desenfileirar();
			Desenfileirar();

			MostrarFila();
		}

		private static void Desenfileirar()
		{
			if (pedagio.Any())
			{
				if (pedagio.Peek() == "guincho")
				{
					Console.WriteLine("guincho esta fazendo o pagamento");
				}
				string veiculo = pedagio.Dequeue();
				Console.WriteLine($"- Saiu da filha {veiculo}");
			}
		}

		private static void Enfileirar(string veiculo)
		{
			Console.WriteLine($"- Entrou na filha {veiculo}");
			pedagio.Enqueue(veiculo);			
		}
		private static void MostrarFila()
		{
			Console.WriteLine("- PEGADIO");

			foreach (var vei in pedagio)
			{
				Console.WriteLine(vei);
			}
		}
	}
}
