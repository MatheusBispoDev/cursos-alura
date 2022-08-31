using System;
using System.Collections.Generic;

namespace bytebank_ADM.SistemaInterno
{
	public interface IAutenticavel
	{
		public bool Autenticar(string senha);
	}
}
