using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1.Models
{
	class Aluno
	{
		private string nome;
		private int numeroMatricula;

		public Aluno(string nome, int numeroMatricula)
		{
			this.nome = nome;
			this.numeroMatricula = numeroMatricula;
		}
		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		public int NumeroMatricula
		{
			get { return numeroMatricula; }
			set { numeroMatricula = value; }
		}

		public override string ToString()
		{
			return $"[Aluno: {this.nome}, Matricula: {this.numeroMatricula}]";
		}
		public override bool Equals(object obj) //caso o metodo Equals seja reescrito, tem que reescrever o GetHashCode()
		{
			Aluno outro = obj as Aluno;

			if(outro == null)
			{
				return false;
			}

			return this.nome.Equals(outro.nome);
		}
		public override int GetHashCode()
		{
			return this.nome.GetHashCode();
		}
	}
}
