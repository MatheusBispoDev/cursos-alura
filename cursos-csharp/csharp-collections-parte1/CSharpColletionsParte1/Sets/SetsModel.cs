using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpColletionsParte1.Lista_de_Objetos;
using CSharpColletionsParte1.Models;

namespace CSharpColletionsParte1.Sets
{
	class SetsModel
	{
		public static void TrabalhandoSetsModel()
		{
			Console.WriteLine("---------------- SET MODEL -----------------");
			Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
			csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
			csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
			csharpColecoes.Adiciona(new Aula("Modelando com Colecoes", 24));

			Aluno aluno1 = new Aluno("Vanessa Tonini", 34672);
			Aluno aluno2 = new Aluno("Ana Losnak", 5617);
			Aluno aluno3 = new Aluno("Rafael Nercessian", 17645);

			csharpColecoes.Matricula(aluno1);
			csharpColecoes.Matricula(aluno2);
			csharpColecoes.Matricula(aluno3);

			foreach(var aluno in csharpColecoes.Alunos)
			{
				Console.WriteLine(aluno);
			}

			Console.WriteLine($"O aluno 01 {aluno1.Nome} esta matriculado?");

			Console.WriteLine(csharpColecoes.EstaMatriculado(aluno1));

			Aluno tonini = new Aluno("Vanessa Tonini", 34672);
			
			Console.WriteLine($"Tonini esta matriculado? {csharpColecoes.EstaMatriculado(tonini)}");
			Console.WriteLine($"aluno1 == tonini? {aluno1 == tonini}");
			Console.WriteLine($"aluno1 e equals a tonini? {aluno1.Equals(tonini)}");

			//Nova colocao: Dicionario
			//um dicionario permite associar uma chave (no caso, matricula) a um valor (o aluno)
			//vamos implementar um dicionar de alunos em Curso

			//implementando Curso.BuscaMatriculado
			Console.WriteLine("Quem e o aluno com matricula 5617?");
			Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
			Console.WriteLine($"aluno5617: {aluno5617}");

			Console.WriteLine("Quem e o aluno com matricula 5618?");
			Aluno aluno5618 = csharpColecoes.BuscaMatriculado(5618);
			Console.WriteLine($"aluno5618: {aluno5618}");

			//e se tenteramos adicionar outro aluno com mesma chave 5617?
			Aluno fabio = new Aluno("Fabio Gushiken", 5617);
			//csharpColecoes.Matricula(fabio); //da erro pois a chave do dicionario e unica
			csharpColecoes.SubstituiAluno(fabio);

			Console.WriteLine($"Quem e o aluno com matricula 5617 agora? {csharpColecoes.BuscaMatriculado(5617)}");
			
			//como um dicionario armazena os valores (diagrama) - funciona como um HashSet
			//Ele tambem tem codigo de dispersao: tem caixinhas na memoria que armazenam os valores pela codigo
		}
	}
}
