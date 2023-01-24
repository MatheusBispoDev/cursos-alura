using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte2.Models
{
	class Mes	//: IComparable
	{
		public Mes(string nome, int dias)
		{
			Nome = nome;
			Dias = dias;
		}
		public string Nome { get; private set; }
		public int Dias { get; private set; }

		//public int CompareTo(object obj)
		//{
		//	Mes outro = obj as Mes;
		//
		//	return this.Nome.CompareTo(outro.Nome);
		//}

		public override string ToString()
		{
			return $"{Nome} - {Dias}";
		}
	}
}
