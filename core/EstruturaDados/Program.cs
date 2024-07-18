﻿using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace EstruturaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();

            WriteLine("###### Exemplo Lista comum vs Array list ######");

            // tamanho fixo, value types elements, pode ser multidimensional, um pouco mais rápido que Arraylist
            // Type safe - garante segurança do mesmo tipo de dado
            int[] array = new int[4] { 1, 2, 3, 4 };

            // tamanho dinamico, reference type elements, single-dimencional(dimensao unica), um pouco mais lento que Array
            // not type safe
            // Heterogenio (pode salvar objetos de diferentes tipos)
            ArrayList arrayList = new ArrayList();
            arrayList.Add("string");
            arrayList.Add(10);
            arrayList.Add(new object());
            arrayList.Add(false);

            
            // Homogenio (pode salvar objetos de um único tipo)
            // oferece mais suporte
            // Type safe
            // mais performance
            List<int> list = new List<int>();




            WriteLine("###### Exemplo pilha  LIFO(Last in first out) ######");
            // ************************ ///
            // Estrutura de dados Pilha
            Stack<int> p1 = new Stack<int>();

            p1.Push(1);
            p1.Push(2);
            p1.Push(3);
            p1.Push(4);
            p1.Push(5);



            WriteLine($"A pilha tem { p1.Count} itens");
            // Conversão para Array
            // WriteLine(p1.ToArray().GetValue(2));

            WriteLine($"último elemento adicionado na lista: {p1.Peek()}");

            WriteLine("Removendo item da pilha... ");
            p1.Pop();

            WriteLine($"A pilha tem {p1.Count} itens.");
            WriteLine($"último elemento adicionado na lista: {p1.Peek()}");

            ReadKey();
            Clear();




            WriteLine("##### Exemplo de FILA FIFO(First in first out) ######");

            // ************************ ///
            // Estrutura de dados Fila
            Queue<string> f1 = new Queue<string>();
            // Adiciona item na lista
            f1.Enqueue("Andre");
            f1.Enqueue("Amanda");
            f1.Enqueue("Tony Stark");
            WriteLine($"A Fila tem {f1.Count} itens");

            WriteLine($"Primeiro elemento adicionado na lista: {f1.Peek()}");

            WriteLine($"O item {f1.Dequeue()} for retirado");


            WriteLine($"A Fila tem {f1.Count} itens");


            ReadKey();
            Clear();


            WriteLine("##### Exemplo de Tuplas heterogenio (Város tipos de dados) ######");
            // ************************ ///
            // Estrutura de dados Tupla
            // Forma antiga antes do C# 7 
            // ->>>>>> var pares = System.Tuple.Create(2, 4, 6, 7, 8, 10);

            // Utilizando C# 7
            (string, string, decimal) brasil = ("Brasil", "Brasilia", 1268.33m);

            WriteLine($"O {brasil.Item1}, cuja sua capital é {brasil.Item2} tem RPC(renda per cap) de R$ {brasil.Item3} ");

            // Renomeando itens da tupla
            (string nome, int populacao, string capital, decimal rpc) brasilRenomeado = ("Brasil", 200, "Brasilia", 1268.33m);
            WriteLine($"O {brasilRenomeado.nome}, cuja sua capital é {brasilRenomeado.capital} tem RPC(renda per cap) de R$ {brasilRenomeado.rpc}");


            ReadKey();
        }
    }
}
