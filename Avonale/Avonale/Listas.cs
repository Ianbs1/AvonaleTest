using System;
using System.Collections.Generic;
using System.Text;

namespace Avonale
{
    class Listas
    {
        // Classe com os métodos da questão 02.

        private int _quantidade;
        public double Soma { get; private set; }

        public Listas()
        {

        }

        public Listas(int quantidade, double soma)
        {
            _quantidade = quantidade;
            Soma = soma;
        }




        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value >= 0)
                {
                    _quantidade = value;
                }
            }
        }


        public Double CalcMedia(int[] vetor, int quantidade, double soma)
        {

            if (quantidade > 0)
            {
                soma = soma + vetor[quantidade - 1];
                return CalcMedia(vetor, quantidade - 1, soma);

            }
            else return soma / _quantidade;

        }

        public List<int> MaiorQMedia(List<int> num, double media)
        {
            Quantidade = num.Count;
            if (num == null || Quantidade <= 0)
            {
                return null;
            }
            else if (num[num.Count - 1] > media)
            {
                Console.Write(num[num.Count - 1] + " ");



            }
            num.RemoveAt(num.Count - 1);
            return MaiorQMedia(num, media);




        }



        public List<char> Inverte(List<char> list)
        {


            Quantidade = list.Count;
            if (list == null || Quantidade <= 0)
            {
                return null;
            }

            Console.Write(list[list.Count - 1] + " ");
            list.RemoveAt(list.Count - 1);
            return Inverte(list);
        }

    }
}
