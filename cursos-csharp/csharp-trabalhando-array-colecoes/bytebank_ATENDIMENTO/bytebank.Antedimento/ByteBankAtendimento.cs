using System;
using System.Collections.Generic;
using System.Linq;
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.bytebank.Antedimento
{
#nullable disable
	internal class ByteBankAtendimento
	{

		private static List<ContaCorrente> _listaDeContas = new()
		{
			new ContaCorrente(91, "MATHEUS-A") { Saldo = 100, Titular = new Cliente { Cpf = "11111", Nome = "Henrique" } },
			new ContaCorrente(91, "MATHEUS-B") { Saldo = 50, Titular = new Cliente { Cpf = "22222", Nome = "Pedro" } },
			new ContaCorrente(91, "MATHEUS-C") { Saldo = 10, Titular = new Cliente { Cpf = "33333", Nome = "Marisa" } },
		};

		public static void AtendimentoCliente()
		{
			try
			{
				char opcao = '0';
				while (opcao != '6')
				{
					Console.Clear();
					Console.WriteLine("===============================");
					Console.WriteLine("===       Atendimento       ===");
					Console.WriteLine("===1 - Cadastrar Conta      ===");
					Console.WriteLine("===2 - Listar Contas        ===");
					Console.WriteLine("===3 - Remover Conta        ===");
					Console.WriteLine("===4 - Ordenar Contas       ===");
					Console.WriteLine("===5 - Pesquisar Conta      ===");
					Console.WriteLine("===6 - Sair do Sistema      ===");
					Console.WriteLine("===============================");
					Console.WriteLine("\n\n");
					Console.Write("Digite a opção desejada: ");
					try
					{
						opcao = Console.ReadLine()[0];
					}
					catch (Exception excecao)
					{

						throw new ByteBankExceptions(excecao.Message);
					}

					switch (opcao)
					{
						case '1':
							CadastrarConta();
							break;
						case '2':
							ListarContas();
							break;
						case '3':
							RemoverContas();
							break;
						case '4':
							OrdenarContas();
							break;
						case '5':
							PesquisarContas();
							break;
						case '6':
							EncerrarAplicacao();
							break;
						default:
							Console.WriteLine("Opcao não implementada.");
							break;
					}
				}
			}
			catch (ByteBankExceptions excecao)
			{
				Console.WriteLine($"{excecao.Message}");
			}

		}

		private static void EncerrarAplicacao()
		{
			Console.WriteLine("... Encerrando a aplicação ...");
			Console.ReadKey();
		}

		public static void PesquisarContas()
		{
			Console.Clear();
			Console.WriteLine("===============================");
			Console.WriteLine("===    PESQUISAR CONTAS     ===");
			Console.WriteLine("===============================");
			Console.WriteLine("\n");
			Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2) CPF TITULAR ? ou (3) NUMERO AGENCIA ");
			switch (int.Parse(Console.ReadLine()))
			{
				case 1:
					{
						Console.Write("Informe o número da Conta: ");
						string _numeroConta = Console.ReadLine();
						ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
						Console.Write(consultaConta.ToString());
						Console.ReadKey();
						break;
					}
				case 2:
					{
						Console.Write("Informe o CPF do Titular: ");
						string _cpf = Console.ReadLine();
						ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
						Console.Write(consultaCpf.ToString());
						Console.ReadKey();
						break;
					}
				case 3:
					{
						Console.Write("Informe o Nº da Agência: ");
						int _numeroAgencia = int.Parse(Console.ReadLine());
						var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
						ExibirListaDeContas(contasPorAgencia);
						Console.ReadKey();
						break;
					}
				default:
					Console.WriteLine("Opção não implementada.");
					break;
			}
		}

		private static void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
		{
			if (contasPorAgencia == null)
			{
				Console.WriteLine("... A consulta não retornou dados ...");
			}
			else
			{
				foreach (var item in contasPorAgencia)
				{
					Console.WriteLine(item.ToString());
				}
			}
		}

		private static List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
		{
			var consulta = (
				from conta in _listaDeContas
				where conta.Numero_agencia == numeroAgencia
				select conta).ToList();

			return consulta;
		}

		public static ContaCorrente ConsultaPorCPFTitular(string cpf)
		{
			return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();

			//ContaCorrente conta = null;
			//for (int i = 0; i < _listaDeContas.Count; i++)
			//{
			//	if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
			//	{
			//		conta = _listaDeContas[i];
			//	}
			//}
			//return conta;
		}
		public static ContaCorrente ConsultaPorNumeroConta(string numeroConta)
		{
			return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();

			//ContaCorrente conta = null;
			//for (int i = 0; i < _listaDeContas.Count; i++)
			//{
			//	if (_listaDeContas[i].Conta.Equals(numeroConta))
			//	{
			//		conta = _listaDeContas[i];
			//	}
			//}
			//return conta;
		}
		public static void OrdenarContas()
		{
			_listaDeContas.Sort();
			Console.WriteLine("... Lista de contas ordenada ...");
			Console.ReadKey();
		}
		public static void RemoverContas()
		{
			Console.Clear();
			Console.WriteLine("===============================");
			Console.WriteLine("===      REMOVER CONTAS     ===");
			Console.WriteLine("===============================");
			Console.WriteLine("\n");
			Console.Write("Informe o número da Conta: ");
			string numeroConta = Console.ReadLine();

			ContaCorrente conta = null;

			foreach (var item in _listaDeContas)
			{
				if (item.Conta.Equals(numeroConta))
				{
					conta = item;
				}
			}
			if (conta != null)
			{
				_listaDeContas.Remove(conta);
				Console.WriteLine("... Conta removida da lista! ...");
			}
			else
			{
				Console.WriteLine(" ... Conta para remoção não encontrada ...");
			}
			Console.ReadKey();
		}
		public static void ListarContas()
		{
			Console.Clear();
			Console.WriteLine("===============================");
			Console.WriteLine("===     LISTA DE CONTAS     ===");
			Console.WriteLine("===============================");
			Console.WriteLine("\n");

			if (_listaDeContas.Count <= 0)
			{
				Console.WriteLine("... Não há contas cadastradas! ...");
				Console.ReadKey();
				return;
			}

			foreach (ContaCorrente item in _listaDeContas)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
				Console.ReadKey();
			}
		}
		public static void CadastrarConta()
		{
			Console.Clear();
			Console.WriteLine("===============================");
			Console.WriteLine("===   CADASTRO DE CONTAS    ===");
			Console.WriteLine("===============================");
			Console.WriteLine("\n");
			Console.WriteLine("=== Informe dados da conta ===");

			Console.Write("Número da Agência: ");
			int numeroAgencia = int.Parse(Console.ReadLine());

			ContaCorrente conta = new(numeroAgencia);
			
			Console.WriteLine($"Numero da conta [NOVA] : {conta.Conta}");

			Console.Write("Informe o saldo inicial: ");
			conta.Saldo = double.Parse(Console.ReadLine());

			Console.Write("Infome nome do Titular: ");
			conta.Titular.Nome = Console.ReadLine();

			Console.Write("Infome CPF do Titular: ");
			conta.Titular.Cpf = Console.ReadLine();

			Console.Write("Infome Profissão do Titular: ");
			conta.Titular.Profissao = Console.ReadLine();

			_listaDeContas.Add(conta);

			Console.WriteLine("... Conta cadastrada com sucesso! ...");
			Console.ReadKey();
		}

	}
}
