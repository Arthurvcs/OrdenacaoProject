using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoProject
{
    public static class Selecao
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="vet">vetor informado pelo usuário</param>
        /// <returns>O vetor ordenado</returns>
        public static int[] Ordenar(int[] vet)
        {
            int aux, aux2;

            for (int i = 0; i < vet.Length - 1; i++)
            {
                aux = i;
                for (int j = i + 1; j < vet.Length; j++)
                    if (vet[j] < vet[aux])
                        aux = j;

                if (aux != i)
                {
                    aux2 = vet[aux];
                    vet[aux] = vet[i];
                    vet[i] = aux2;
                }
            }
            return vet;
        }
    }
}
