using System;

namespace _2_CriandoVariaveis
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Projeto 2 - Criando Variáveis");
			// Variável do tipo Inteiro
			int idade;
			idade = (5 - 2) * 6;
			Console.WriteLine("Minha idade é : " + idade);

			// Variável do tipo ponto flutuante - decimal
			double salario;
			salario = 3000.13;
			Console.WriteLine("Meu salário é de : " + salario);

			double altura;
			altura = 7.0 / 4.0;	// Boa prática colocar o .0 quando for um inteiro numa variável double
			Console.WriteLine("Minha altura é de : " + altura);

			Console.WriteLine("Tecle enter para fechar...");
			Console.ReadLine();
		}
	}
}
