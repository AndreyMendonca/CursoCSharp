using System;
using System.Collections.Generic;

namespace List {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //insert = adicionar um valor de acordo com a posição.
            list.Insert(2, "Marco");

            //Count = tamanho da lista
            Console.WriteLine("Tamanho da lista: " + list.Count);

            //Find = primeiro valor encontrado;
            string s1 = list.Find( x => x[0] == 'A');
            Console.WriteLine("First 'A' : " + s1);
            //FindLest para encontrar o ultimo
            //FindIndex = retorar a posicao FindLastIndex =  retorna o ultimo da posicao

            //FindAll() = uma nova lista de acordo com a regra

            List<string> list2 = list.FindAll(x => x.Length == 5);

            //Remove() = remover alguem especifico
            //RemoveAll() = lambida com a regra
            //RemoveAt() =  remover pela posição
            //RemoveRange(posicao, quantos elemento)
            foreach(string nome in list) {
                Console.WriteLine(nome);
            }

        }
    }
}