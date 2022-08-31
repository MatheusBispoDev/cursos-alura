using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
	public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
	{
		public FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario) { }

		public string Senha { get; set; }

		public bool Autenticar(string senha)
		{
			return this.Senha == senha;
		}
	}
}
