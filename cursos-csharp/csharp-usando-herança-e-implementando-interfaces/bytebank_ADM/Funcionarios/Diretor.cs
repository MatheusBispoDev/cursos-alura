
namespace bytebank_ADM.Funcionarios
{
	public class Diretor : FuncionarioAutenticavel
	{
		public Diretor(string nome, string cpf) : base(nome, cpf, 5000) { } // base = ele faz referência a classe base (classe mãe)

		public override void AumentarSalario()
		{
			this.Salario *= 1.5;
		}

		public override double GetBonificacao() // override = indica que está reescrevendo um método
		{			
			return this.Salario * 0.5; 
		}
	}
}
