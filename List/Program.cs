using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //Adiciona
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Lorenzo");
            list.Add("Denise");
            list.Add("Leonardo");

            //Insere em determinada posição da lista
            list.Insert(1, "Felipe");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Informa quantos itens tem na lista
            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine();

            //Encontra o primeiro nome que se incia com a letra 'A'
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome que inicia com a letra 'A': " + s1);
            Console.WriteLine();

            //Encontra o ultimo nome que se inicia com a letra 'A'
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome que inicia com a letra 'A': " + s2);
            Console.WriteLine();

            //Emcontra a primeira posição do item que inicia com a letra 'A'
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição que inicia com a letra 'A': " + pos1);
            Console.WriteLine();

            //Emcontra a ultima posição do item que inicia com a letra 'A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição que inicia com a letra 'A': " + pos2);

            //Encontra todos os nomes que tem com tamanho 5 caracteres como determina o parametro
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Nomes contendo 5 caracteres: ");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remove determinado item ou nome da lista
            list.Remove("Alex");
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove desde uma posição inciada até quantas posições seguintes forem determinadas 
            list.RemoveRange(2, 2);
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove um determoinado item pela posição
            list.RemoveAt(1);
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove todos os nomes que se incia com 'M'
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
