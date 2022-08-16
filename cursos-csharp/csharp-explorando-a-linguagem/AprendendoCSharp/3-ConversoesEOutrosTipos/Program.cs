using System;

namespace _3_ConversoesEOutrosTipos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Projeto 3 - Convertendo Variáveis e Outros Tipos");

			double salario = 3000.15;

			int salarioInteiro = (int) salario;
			Console.WriteLine("Meu salário inteiro é de : " + salarioInteiro);

			long x = 20000000000000;    // Um inteiro com uma capacidade de armazenamento maior - 64 bits
			Console.WriteLine("Valor de x : " + x);

			short y = 15000; // Um inteiro com uma capacidade de armazenamento menor
			Console.WriteLine("Valor de y : " + y);

			float altura = 1.62f; // float
			Console.WriteLine("Altura : " + altura);

			Console.WriteLine("Tecle enter para fechar...");
			Console.ReadLine();
		}
	}
}
