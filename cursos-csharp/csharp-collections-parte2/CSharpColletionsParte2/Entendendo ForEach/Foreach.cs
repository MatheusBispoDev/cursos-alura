using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte2.Entendendo_ForEach
{
	class Foreach
	{
		public static void EntendoForeach()
		{
            var meses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            var arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in meses)
            {
                //mes = mes.ToUpper(); //Nao e possivel mudar a variavel usada para percorrer o laco (erro de compilacao)
                //meses[0] = meses[0].ToUpper(); //(erro em execucao) nao e possivel modificar a colecao que esta para ser percorrida
                Console.WriteLine(mes);
            }

            foreach (var mes in arrayMeses)
            {                
                meses[0] = meses[0].ToUpper();
                //nao da erro quando e array pois o foreach quando e array funciona como um for, dessa forma
                //nao da problema se alterar os dados que estao sendo percorridos. Coisa que nao ocorre quando
                //e uma List<>
                Console.WriteLine(mes);
            }
        }
	}
}
