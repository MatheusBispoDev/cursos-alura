using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
	class Designer : Funcionario
	{
		public Designer(string nome, string cpf) : base(nome, cpf, 3000) { }

		public override void AumentarSalario()
		{
			this.Salario *= 1.11;
		}

		public override double GetBonificacao() // override = indica que está reescrevendo um método
		{
			return this.Salario * 0.17;
		}

	}
}
