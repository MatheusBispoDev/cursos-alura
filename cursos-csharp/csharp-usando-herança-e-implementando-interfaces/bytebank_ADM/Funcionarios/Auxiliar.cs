using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
	class Auxiliar : Funcionario
	{
		public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000) { }
		public override void AumentarSalario()
		{
			this.Salario *= 20;
		}
		public override double GetBonificacao() // override = indica que está reescrevendo um método
		{
			return this.Salario * 0.10;
		}
	}
}
