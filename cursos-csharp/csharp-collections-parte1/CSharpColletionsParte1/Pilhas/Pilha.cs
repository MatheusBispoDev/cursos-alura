using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1.Pilhas
{
	class Pilha
	{
		public static void TrabalhandoPilha()
		{
			var navegador = new Navegador();

			navegador.NavegarPara("google.com");
			navegador.NavegarPara("caelum.com.br");
			navegador.NavegarPara("alura.com.br");
			//navegador.NavegarPara("youtube.com");

			navegador.Anterior();
			navegador.Anterior();
			navegador.Anterior();	

			navegador.Proximo();
		}

		internal class Navegador
		{
			private readonly Stack<string> historicoAnterior = new Stack<string>();
			private readonly Stack<string> historicoProximo = new Stack<string>();
			private string atual = "vazia";

			public Navegador()
			{
				Console.WriteLine($"Pagina atual: {atual}");
			}

			internal void Anterior()
			{
				if (historicoAnterior.Any())
				{
					historicoProximo.Push(atual);
					atual = historicoAnterior.Pop();
					Console.WriteLine($"Voltou para: {atual}");
				}
				else
				{
					Console.WriteLine("Pilha Vazia");
				}
			}
			internal void NavegarPara(string url)
			{
				historicoAnterior.Push(url);
				atual = url;
				Console.WriteLine($"Navegou para: {atual}");
			}
			internal void Proximo()
			{
				if (historicoProximo.Any())
				{
					historicoAnterior.Push(atual);
					atual = historicoProximo.Pop();
					Console.WriteLine("Página atual: " + atual);
				}
			}
		}
	}
}
