﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
	public class SaldoInsuficienteException : OperacaoFinanceiraException
	{
		public SaldoInsuficienteException(string mensagem) : base(mensagem)
		{

		}
	}
}
