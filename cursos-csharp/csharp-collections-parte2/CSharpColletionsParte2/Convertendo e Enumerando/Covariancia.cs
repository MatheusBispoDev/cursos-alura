using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte2.Convertendo_e_Enumerando
{
	class Covariancia
	{
		public static void TrabalhandoCovariancia()
		{
			Console.WriteLine("-------------------- OPERADORES DE CONJUNTO --------------------");

			string titulo = "meses";
			object obj = titulo; //Conversao implicita pois a class String herda da classe Object

			Console.WriteLine(obj);

			Console.WriteLine("List<string> para List<object>");

			IList<string> listaMeses = new List<string>
			{
					"Janeiro", "Fevereiro", "Março",
					"Abril", "Maio", "Junho",
					"Julho", "Agosto", "Setembro",
					"Outubro", "Novembro", "Dezembro"
			};
			//Nao e possivel fazer uma conversao implicita, pois a interface IList<> nao permite
			//IList<object> listaObj = listaMeses; //erro em momento de compilacao

			//IList<object> listaObj = listaMeses;
			Console.WriteLine();

			Console.WriteLine("strin[] para object[]?");
			string[] arrayMeses = new string[]
			{
				"Janeiro", "Fevereiro", "Março",
				"Abril", "Maio", "Junho",
				"Julho", "Agosto", "Setembro",
				"Outubro", "Novembro", "Dezembro"
			};
			//Nao da erro e consegue converter implicitament, pois e uma Covariância
			//No .NET Framework 4 e versões mais recentes, o C# oferece suporte à covariância e á contravariância em
			//interfaces e delegados genéricos, e permite a conversão implícita de parâmetros de tipo genérico.
			//Para obter mais informações, consulte Variação em interfaces genéricas (C#) e Variação em delegados (C#).
			//link https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/covariance-contravariance/
			object[] arrayObj = arrayMeses;
			Console.WriteLine(arrayObj);
			foreach (var item in arrayObj)
			{
				Console.WriteLine(item);
			}

			arrayObj[0] = "PRIMEIRO MÊS";
			Console.WriteLine(arrayObj[0]);
			Console.WriteLine();

			//Da erro em momento de execucao, pois antes da conversao implicita (covariância)
			//este array era de string, logo ele so pode armazenar informacoes desse tipo de dados
			//qualquer outro tipo de dados da erro ao tentar atribuir
			//Logo, a convarianca do array em .NET Framework deve ser evitada (exemplo de utilizacao abaixo)
			//arrayObj[0] = 12345; 
			//Console.WriteLine(arrayObj[0]);
			//Console.WriteLine();

			IEnumerable<object> enumObj = listaMeses; //COVARIÂNCIA
			foreach (var item in enumObj)
			{
				Console.WriteLine(item);
			}			
		}

	}
}
