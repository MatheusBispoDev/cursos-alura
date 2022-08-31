using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitarios
{
	public class GerenciadorDeBonificacao
	{
		private double _totalBonificao;
		
		public void Registrar(Funcionario funcionario)
		{
			this._totalBonificao += funcionario.GetBonificacao();
		}

		public double GetBonificacao()
		{
			return this._totalBonificao;
		}
	}
}
