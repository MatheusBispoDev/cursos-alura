using System;
using bytebank.Titular;

namespace bytebank
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");

			Cliente cliente1 = new("Layza Cristina", "746.487.757.45");
			cliente1.Profissao = "Designer";

			ContaCorrente conta1 = new(23, "20123-1");

			conta1.Cliente = cliente1;
			conta1.Nome_agencia = "Agência Central";
			conta1.Saldo = 500.56;

			Cliente cliente2 = new("Matheus Bispo", "000.000.000.00");
			cliente2.Profissao = "Programador";

			ContaCorrente conta2 = new(23, "10123-1");

			conta2.Cliente = cliente2;
			conta2.Nome_agencia = "Agência Central";
			conta2.Saldo = 50.00;

			Console.WriteLine(conta1.ExibeMensagem());

			bool saqueRealizado = conta1.Sacar(50);
			Console.WriteLine("Saque realizado: " + saqueRealizado + "\n Saldo de: " + conta1.Saldo);

			bool depositoRealizado = conta1.Depositar(50);
			Console.WriteLine("Deposito realizado: " + depositoRealizado + "\n Saldo de: " + conta1.Saldo);

			bool transferenciaRealizada = conta1.Transferir(50.00, conta2);
			Console.WriteLine("Transferência realizada: " + transferenciaRealizada + "\n Saldo de: " + conta1.Saldo + "\n");

			Console.WriteLine(conta1.ExibeMensagem());

			Console.WriteLine(conta2.ExibeMensagem());

			Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
		}
	}
}