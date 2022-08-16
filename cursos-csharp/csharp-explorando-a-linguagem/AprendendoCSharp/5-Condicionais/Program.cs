using System;

namespace _5_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Projeto 5 - Condicionais");

			int idadeJoao = 16;
			int quantidadePessoas = 2;
			
			bool acompanhado = quantidadePessoas > 1;

			string textoAdicional;

			if(acompanhado == true)
			{
				//string textoAdicional = "João está acompanhado"; // Está variável deixará de existir assim que o if acabar
				textoAdicional = "João está acompanhado";
			}
			else
			{
				textoAdicional = "João não está acompanhado";
			}

			// Se João tiver mais de 18 anos ou a quantidade de pessoas esteja maior que 0
			// && = AND
			// || = OR
			if (idadeJoao >= 18 || acompanhado)
			{				
				Console.WriteLine("Pode entrar! ");
				Console.Write(textoAdicional);
			}
			else
			{
				Console.WriteLine("Não pode entrar!");
			}

			Console.WriteLine("Tecle enter para fechar...");
			Console.ReadLine();
		}
	}
}
