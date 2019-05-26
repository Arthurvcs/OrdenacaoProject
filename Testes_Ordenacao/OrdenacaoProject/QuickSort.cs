using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ORDENACAO
{
    public class QuickSort
    {
        /// <summary>
        /// Método publico para o usuário Organizar um vetor
        /// </summary>
        /// <param name="vet">vetor informado pelo usuário</param>
        /// <returns>O vetor organizado</returns>
        static public int[] Ordenar(int[] vet)
        {
            QuickSort_Recursive(vet, 0, vet.Length - 1);
            return vet;
        }
        /// <summary>
        /// Método privado para ordenar um vetor
        /// </summary>
        /// <param name="vet">vetor</param>
        /// <param name="inicio">posição inicial do vetor</param>
        /// <param name="fim">posição final do vetor</param>
        static int[] QuickSort_Recursive(int[] vetor, int primeiro, int ultimo)
        {

            int baixo, alto, meio, pivo, repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);

            pivo = vetor[meio];

            while (baixo <= alto)
            {
                while (vetor[baixo] < pivo)
                    baixo++;
                while (vetor[alto] > pivo)
                    alto--;
                if (baixo < alto)
                {
                    repositorio = vetor[baixo];
                    vetor[baixo++] = vetor[alto];
                    vetor[alto--] = repositorio;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }
            }

            if (alto > primeiro)
            { QuickSort_Recursive(vetor, primeiro, alto); }
            if (baixo < ultimo)
            { QuickSort_Recursive(vetor, baixo, ultimo); }
            return vetor;
        }
    }
}
