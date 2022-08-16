using System;

namespace _7_CalculaPoupanca
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Projeto 7 - Calcula Poupança");

			double investimento = 1000;
			double fatorRendimento = 1.005;

			// Rendimento de 0.5% (0.005) ao mês
			//while (mes <= 12)
			for (int anos = 1; anos <= 5; anos++)
			{

				for (int mes = 1; mes <= 12; mes++)
				{
					investimento *= fatorRendimento;
					//Console.WriteLine("No " + mes + "° você tem de: " + investimento + "R$ de investimento");
				}
				fatorRendimento += 0.001;
			}

			Console.WriteLine("Depois de 5 anos vc terá " + investimento + "R$ de investimento");

			Console.WriteLine("Tecle enter para fechar...");
			Console.ReadLine();
		}
	}
}
