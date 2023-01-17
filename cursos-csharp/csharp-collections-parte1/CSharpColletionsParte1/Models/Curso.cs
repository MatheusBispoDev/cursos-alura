using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpColletionsParte1.Models;

namespace CSharpColletionsParte1.Lista_de_Objetos
{
	class Curso
	{		
		private string nome;
		private string instrutor;
		private ISet<Aluno> alunos = new HashSet<Aluno>();
		private IList<Aula> aulas;
		//implementando um dicionario de alunos
		private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();


		public IList<Aluno> Alunos
		{
			get
			{
				return new ReadOnlyCollection<Aluno>(alunos.ToList());
			}			
		}
		public Curso(string nome, string instrutor)
		{
			this.nome = nome;
			this.instrutor = instrutor;
			this.aulas = new List<Aula>();
		}
		internal void Adiciona(Aula aula)
		{
			this.aulas.Add(aula);
		}
		public override string ToString()
		{
			return $"[Curso: {this.nome}, Instrutor: {this.instrutor}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}]";
			//string.Join vai unir as informacoes de uma colecao
		}
		public IList<Aula> Aulas
		{
			get { return new ReadOnlyCollection<Aula>(aulas) ; } //Lista que e somente leitura
		}
		internal void Matricula(Aluno aluno)
		{
			this.alunos.Add(aluno);
			this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
		}
		public bool EstaMatriculado(Aluno aluno)
		{
			return alunos.Contains(aluno);
		}
		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}		
		public string Instrutor
		{
			get { return instrutor; }
			set { instrutor = value; }
		}
		public int TempoTotal
		{
			get
			{
				//int total = 0;
				//foreach(var aula in aulas)
				//{
				//	total += aula.Tempo;
				//}				
				//return total;

				//LINQ = Language Integrated Query
				//Consulta Integrada a Linguagem

				return aulas.Sum((aula) => aula.Tempo);
			}
		}
		internal Aluno BuscaMatriculado(int numeroMatricula)
		{
			Aluno aluno = null;
			this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
			return aluno;
		}

		internal void SubstituiAluno(Aluno aluno)
		{
			this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
		}
	}
}
