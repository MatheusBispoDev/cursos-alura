using System;

namespace _4_CaracteresETextos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Projeto 4 - Criando variáveis Caracteres e Textos");

			// char só guarda 1 caractere e não é possível criar vazia, precisa criar com um espaço em branco no minímo
			char letra = 'a';
			Console.WriteLine(letra);

			letra = (char) 65; // Tabela ASCII o número 65 corresponde a letra A
			Console.WriteLine(letra);

			string primeiraFrase = "Alura - Cursos de tecnologia";
			Console.WriteLine(primeiraFrase);

			string cursos = "Cursos disponíveis:\n- GO\n- C#\n- Python\n- Java";
			Console.WriteLine(cursos);

			Console.WriteLine("Tecle enter para fechar...");
			Console.ReadLine();
		}
	}
}
