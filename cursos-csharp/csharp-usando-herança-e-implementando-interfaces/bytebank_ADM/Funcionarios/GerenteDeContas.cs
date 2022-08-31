using System;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
	public class GerenteDeContas : FuncionarioAutenticavel
	{
		public GerenteDeContas(string nome, string cpf) : base(nome, cpf, 4000) { }

		public override void AumentarSalario()
		{
			this.Salario *= 1.25;
		}

		public override double GetBonificacao() // override = indica que está reescrevendo um método
		{
			return this.Salario * 0.05;
		}
	}
}
