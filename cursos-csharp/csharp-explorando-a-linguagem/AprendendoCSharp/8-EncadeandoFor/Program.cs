using System;

namespace _8_EncadeandoFor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Projeto 8 - Encadeando For");

			//*
			//**
			//***
			//****
			//*****
			//******

			for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
			{
				for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}

			Console.WriteLine("Tecle enter para fechar...");
			Console.ReadLine();
		}
	}
}
