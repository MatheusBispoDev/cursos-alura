using bytebank.Titular;

namespace bytebank
{
	public class ContaCorrente
	{
		public ContaCorrente(int numero_agencia, string conta)
		{
			Numero_agencia = numero_agencia;
			Conta = conta;
			TotalDeContasCriadas++;
		}

		public Cliente Cliente { get; set; }

		private string _conta;
		public string Conta { get { return _conta; } set { if (value != null) { _conta = value; } } }

		private int _numero_agencia;
		public int Numero_agencia { get { return _numero_agencia; } set { if (_numero_agencia >= 0) { _numero_agencia = value; } } }

		public string Nome_agencia { get; set; }

		private double _saldo;
		public double Saldo { get { return _saldo; } set { if (value > 0) { _saldo = value; } } }

		public static int TotalDeContasCriadas { get; set; }

		public bool Transferir(double valor, ContaCorrente destino)
		{
			if (_saldo < valor || valor < 0)
			{
				return false;
			}

			_saldo -= valor;
			destino._saldo += valor;
			return true;
		}

		public bool Sacar(double valor)
		{
			if (_saldo < valor || valor < 0)
			{
				return false;
			}

			this._saldo -= valor;

			return true;
		}

		public bool Depositar(double valor)
		{
			if (valor < 0)
			{
				return false;
			}

			this._saldo += valor;

			return true;
		}

		public string ExibeMensagem()
		{
			string mensagem = "";

			mensagem += "Titular: " + Cliente.Nome + "\n";
			mensagem += "Conta: " + Conta + "\n";
			mensagem += "Número Agência: " + Numero_agencia + "\n";
			mensagem += "Nome Agência: " + Nome_agencia + "\n";
			mensagem += "Saldo: " + this.Saldo + "\n";

			return mensagem;
		}

	}
}
