using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
	public abstract class Funcionario
	{
		public Funcionario (string nome, string cpf, double salario)
		{
			this.Nome = nome;
			this.Cpf = cpf;
			this.Salario = salario;
			TotalDeFuncionarios++;
		}
		
		public string Nome { get; set; }
		public string Cpf { get; private set; }
		public double Salario { get; protected set; } // protected = É possível utilizar dentro da classe e por suas heranças
		public static int TotalDeFuncionarios { get; private set; }

		public abstract void AumentarSalario();
		public abstract double GetBonificacao(); // virtual = avisa que o método pode ser reescrito
	}
}
