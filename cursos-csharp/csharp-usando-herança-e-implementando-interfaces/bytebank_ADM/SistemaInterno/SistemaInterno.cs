using System;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
	public class SistemaIntern
	{
		public static bool Logar(IAutenticavel funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);

			if(usuarioAutenticado == true)
			{
				Console.WriteLine("Bem vindo ao sistema.");
				return true;
			}

			return false;
		}
	}
}
