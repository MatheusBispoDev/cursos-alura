﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
	public class Cliente
	{
		public Cliente(string nome, string cpf)
		{
			Nome = nome;
			Cpf = cpf;
		}
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Profissao { get; set; }
	}
}
