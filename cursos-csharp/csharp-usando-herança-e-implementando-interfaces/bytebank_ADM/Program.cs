using System;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.ParceriaComercial;

namespace bytebank_ADM
{
	public class Program
	{
		static void Main()
		{
			Console.WriteLine("Boas Vindas ao ByteBank Administração!" + "\n");			

			Desenvolvedor matheus = new("Matheus Bispo", "513.847.112.65");
			ExibeFuncionario(matheus);
			AumentarSalario(matheus);

			Designer cris = new("Layza Cristina", "887.513.004.65");
			ExibeFuncionario(cris);			

			Funcionario[] funcionarios = { matheus, cris};
			CalcularBonificacao(funcionarios);
			
			UsarSistema();

			Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios + "\n");

			void UsarSistema()
			{	
				GerenteDeContas layla = new("Layla Regina", "451.507.132.65");
				layla.Senha = "123";

				Diretor lucas = new("Lucas Bispo", "2413.127.177.48");
				lucas.Senha = "321";

				ParceiroComercial parceiroComercial = new();

				parceiroComercial.Senha = "123";

				SistemaIntern.Logar(layla, "123");
				SistemaIntern.Logar(lucas, "321");
				SistemaIntern.Logar(parceiroComercial, "123");
			}

			void CalcularBonificacao(Funcionario[] funcionarios)
			{
				GerenciadorDeBonificacao gerenciador = new();
				
				for(int i = 0; i < funcionarios.Length; i++)
				{
					gerenciador.Registrar(funcionarios[i]);
				}

				Console.WriteLine("Total Bonificação: " + gerenciador.GetBonificacao());
			}

			void AumentarSalario(Funcionario funcionario)
			{
				funcionario.AumentarSalario();
				Console.WriteLine("Novo salário do " + funcionario.Nome + ": " + funcionario.Salario);
			}

			void ExibeFuncionario(Funcionario funcionario)
			{
				Console.WriteLine("Nome: " + funcionario.Nome);
				Console.WriteLine("CPF: " + funcionario.Cpf);
				Console.WriteLine("Salário: " + funcionario.Salario);
				Console.WriteLine("Bonificação: " + funcionario.GetBonificacao() + "\n");
			}
		}
	}
}
