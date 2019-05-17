using System;
using System.Collections.Generic;

namespace Avonale
{
    class Program
    {
        static void Main(string[] args)
        {

            double resultado;
            int[] vetor = new int[7] { -10, 4, 8, 20, 6, 0, -7 };


            Listas m = new Listas(vetor.Length, 0);



            resultado = m.CalcMedia(vetor, m.Quantidade, m.Soma); // Calcula a media 

            Console.WriteLine("A média é: " + resultado);

            List<int> numeros = new List<int>();
            for (int i = 0; i < vetor.Length; i++)
            {
                numeros.Add(vetor[i]);
            }
            Console.Write("OS números maiores que a média são : ");
            m.MaiorQMedia(numeros, resultado); // Calcula os números maiores que a média
            Console.WriteLine("");


            List<char> list = new List<char>();
            list.Add('D');
            list.Add(':');
            list.Add('a');
            list.Add('t');
            list.Add('a');
            list.Add('r');
            list.Add('t');
            list.Add('n');
            list.Add('o');
            list.Add('c');
            list.Add('e');
            list.Add('M');

            Console.Write("Lista original: ");
            list.ForEach(Console.Write);
            Console.WriteLine("");


            Console.Write("A lista invertida é: ");
            m.Inverte(list); // Retorna a lista invertida
            Console.WriteLine("");


        }






    }
}
