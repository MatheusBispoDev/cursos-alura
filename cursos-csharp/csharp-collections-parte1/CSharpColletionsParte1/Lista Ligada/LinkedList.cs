using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte1.Lista_Ligada
{
	class LinkedList
	{
		public static void TrabalhandoLinkedList()
		{
			Console.WriteLine("---------------- LINKED LIST -----------------");
			List<string> frutas = new List<string>
			{
				"abacate", "banana", "caqui", "damasco", "figo"
			};

			foreach (var fruta in frutas)
			{
				Console.WriteLine(fruta);
			}

			//LinkedList e a colecao mais apropriada para insercao/remocao rapida
			//- Elementos nao precisam estar em sequencia na memoria
			//- Cada elemento sabe quem e o anterior e o proximo 
			//- Cada elemento e um "no" que contem um valor

			LinkedList<string> dias = new LinkedList<string>();
			//adicionando um dia qualquer: "quarta"
			var d4 = dias.AddFirst("quarta"); //"quarta" e o primeiro elemento da lista ligada
			
			//cada elemento e um no: LinkedListNode<T>
			
			//Mas e o valor "quarta"? Esta na propriedade d4.value
			Console.WriteLine($"d4.Value {d4.Value}");

			//para adicionar itens na LinkedList nao e possivel usar o Add
			//ha 4 formas de adicionar
			//1. como primeiro nó (AddFirst());
			//2. como último nó(AddLast());
			//3. antes de um nó previamente conhecido(AddBefore());
			//4. depois de um nó previamente conhecido(AddAfter()).
			Console.WriteLine("---------------- SEMANA -----------------");
			//vamos adicionar "segunda", antes de quarta:
			var d2 = dias.AddBefore(d4, "segunda");
			//agora d2 e d4 estao ligados
			//- d2.Next e igual a d4
			//- d4.Previous e igual a d2
			//vamos adicionar "terca" depois de segunda
			var d3 = dias.AddAfter(d2, "terca");
			//vamos adicionar "sexta" depois da quarta
			var d6 = dias.AddAfter(d4, "sexta");
			//"sabado" depois da "sexta"
			var d7 = dias.AddAfter(d6, "sabado");
			//quinta antes de sexta
			var d5 = dias.AddBefore(d6, "quinta");
			//domingo antes de segunda
			var d1 = dias.AddBefore(d2, "domingo");

			foreach (var dia in dias)
			{
				Console.WriteLine(dia);
			}

			//LinkedList NAO DA suporte ao acesso de indice: dias[0]
			//por isso podemos fazer um laco foreach mas nao um for
			
			//achando um elemento da lista ligada
			var quarta = dias.Find("quarta");

			//Poderemos remover um elemento através do nome do nó, como também pela referência do LinkedListNode.
			//Para removermos quarta - feira, existem as opções dias.
			//Remove("quarta") ou dias.Remove(d4).
		}
	}
}
