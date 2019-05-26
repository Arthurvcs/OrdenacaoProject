using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoProject
{
    public static class BubbleSort
    {
        /// <summary>
        /// Método estático para ordenação, utilizando o método bubbleSort
        /// </summary>
        /// <param name="vet">Vetor informado pelo usuário</param>
        /// <returns>O vetor ordenado</returns>
        public static int[] Ordenar(int[] vet)
        {
            for (int i = (vet.Length - 1); i > 0; i--)
            {
                int trocas = 0;
                for (int j = 0; j < i; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        int aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                        trocas++;
                    }
                }
                if(trocas==0)
                { return vet; }
            }
            return vet;
        }
    }
}
