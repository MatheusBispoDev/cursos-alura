using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpColletionsParte2.LinQs
{
	class OperadoresConjunto
	{
        public static void OperadoresDeConjunto()
        {
            Console.WriteLine("-------------------- OPERADORES DE CONJUNTO --------------------");

            string[] seq1 = { "janeiro", "fevereiro", "marco" };
            string[] seq2 = { "fevereiro", "MARCO", "abril" };

            Console.WriteLine("-- Conectanto duas sequências --");

            var consulta = seq1.Concat(seq2);
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }           

            //Uniao de 2 conjuntos evita valores duplicados, so exibindo uma unica vez
            Console.WriteLine("-- União de duas sequências --");
            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }

            //Uniao de 2 conjuntos com comparador para evitar valores duplicados maiusculos e minusculos
            Console.WriteLine("-- União de duas sequências com comparador --");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }

            //Interseccao de duas sequencias pega os elementos iguais nos 2 conjuntos
            Console.WriteLine("-- Intersecção de duas sequências --");
            var consulta4 = seq1.Intersect(seq2);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }

            //Pega os elementos do 1 conjunto, retirando os elementos do 2 conjunto
            Console.WriteLine("-- Exceto: elementos da seq1 que não estão em seq2 --");
            var consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
