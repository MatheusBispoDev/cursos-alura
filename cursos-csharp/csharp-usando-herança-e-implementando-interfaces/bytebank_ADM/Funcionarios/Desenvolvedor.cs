using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
	class Desenvolvedor : Funcionario
	{
		public Desenvolvedor(string nome, string cpf) : base(nome, cpf, 3000) { }

		public override void AumentarSalario()
		{
			this.Salario *= 0.15;
		}

		public override double GetBonificacao()
		{
			return this.Salario * 0.20;
		}
	}
}
