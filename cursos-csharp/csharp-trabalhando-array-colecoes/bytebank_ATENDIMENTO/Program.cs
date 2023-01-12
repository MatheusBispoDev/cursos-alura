

using System;
using bytebank_ATENDIMENTO.bytebank.Antedimento;

namespace bytebank_ATENDIMENTO
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Boas vindas ao ByteBank, Atendimento.");

			ByteBankAtendimento.AtendimentoCliente();
		}
		
		#region Exemplos Array em C#
		/*
		static void Main(string[] args)
		{
			Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
			
			
			//TestaBuscarPalavra();
			//TestaArrayInt();

			//Array amostra = Array.CreateInstance(typeof(double), 5);
			Array amostra = new double[5];
			amostra.SetValue(5.9, 0);
			amostra.SetValue(1.8, 1);
			amostra.SetValue(7.1, 2);
			amostra.SetValue(10, 3);
			amostra.SetValue(6.9, 4);

			//TestaMediana(amostra);

			TestaArrayDeContasCorrentes();
		}
		public static void TestaArrayDeContasCorrentes()
		{
			ListaDeContasCorrente listaDeContas = new ListaDeContasCorrente();

			listaDeContas.Adicionar(new ContaCorrente(870, "1181438-A"));
			listaDeContas.Adicionar(new ContaCorrente(871, "2281438-B"));
			listaDeContas.Adicionar(new ContaCorrente(872, "3381438-C"));
			listaDeContas.Adicionar(new ContaCorrente(873, "4481438-D"));
			listaDeContas.Adicionar(new ContaCorrente(874, "5581438-E"));
			listaDeContas.Adicionar(new ContaCorrente(875, "6681438-F"));

			ContaCorrente contaMatheus = new ContaCorrente(876, "MATHEUS-G");

			listaDeContas.Adicionar(contaMatheus);

			//listaDeContas.ExibeLista();

			Console.WriteLine("\nListas após remoção\n");

			listaDeContas.Remover(contaMatheus);

			//listaDeContas.ExibeLista();

			for (int i = 4; i < listaDeContas.Tamanho; i++)
			{
				ContaCorrente conta = listaDeContas[i];
				Console.WriteLine($"Indice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
			}
		}
		public static void TestaMediana(Array array)
		{ 
			if ((array == null) || (array.Length != 0))
			{
				Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
			}

			double[] numerosOrdenados = (double[]) array.Clone();
			Array.Sort(numerosOrdenados);

			int tamanho = numerosOrdenados.Length;
			int meio = tamanho / 2;

			double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : 
				(numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

			Console.WriteLine($"Com base na amostra a mediana = {mediana}");
		}
		public static void TestaArrayInt()
		{
			int[] idades = new int[4];

			idades[0] = 30;
			idades[1] = 60;
			idades[2] = 10;
			idades[3] = 20;

			int media = 0;

			Console.WriteLine($"Tamanho Array {idades.Length}");

			for (int i = 0; i < idades.Length; i++)
			{
				int idade = idades[i];
				media += idade;
				Console.WriteLine($"Idade da posicao {i + 1} = {idade}");
			}

			media /= idades.Length;

			Console.WriteLine($"Media = {media}");
		}
		public static void TestaBuscarPalavra()
		{
			string[] arrayDePalavras = new string[5];

			for(int i = 0; i < arrayDePalavras.Length; i++)
			{
				Console.Write($"Digite {i+1} Palavra: ");
				arrayDePalavras[i] = Console.ReadLine();
			}

			Console.Write("Digite palavra a ser encontrada: ");

			var busca = Console.ReadLine();

			foreach (string palavra in arrayDePalavras)
			{
				if (palavra.Equals(busca))
				{
					Console.WriteLine($"Palavra encontrada = {busca}");
					break;
				}
			}
		}
		*/
		#endregion

		#region Exemplos de uso de List
		/*
		static List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
		{
			new ContaCorrente(874, "5679787-A"),
			new ContaCorrente(874, "4456668-B"),
			new ContaCorrente(874, "7781438-C")
		};

		static List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
		{
			new ContaCorrente(951, "5679787-E"),
			new ContaCorrente(321, "4456668-F"),
			new ContaCorrente(719, "7781438-G")
		};

		static void Main(string[] args)
		{
			Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

			//_listaDeContas2.AddRange(_listaDeContas3);
			//_listaDeContas2.Reverse();

			//for (int i = 0; i < _listaDeContas2.Count; i++)
			//{
			//	Console.WriteLine($"indice [{i}] = conta [{_listaDeContas2[i].Conta}]");
			//}

			var range = _listaDeContas3.GetRange(0, 2);
			range.Clear();

			for (int i = 0; i < range.Count; i++)
			{
				Console.WriteLine($"Indice [{i}] = Conta [{range[i].Conta}]");
			}

		//Utilizando Classe Generica
		Generica<int> teste1 = new();
		teste1.MostrarMensagem(10);
		Generica<string> teste2 = new();
		teste2.MostrarMensagem("Teste");

		}

		public class Generica<T>
		{
		public void MostrarMensagem(T t)
		{
			Console.WriteLine($"Mostrar Generica {t}");
		}
		}

		*/
		#endregion
	}
}
