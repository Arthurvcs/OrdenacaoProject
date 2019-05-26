using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoProject
{
    public static class MergeSort
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="vet">Vetor informado pelo usuário</param>
        /// <returns></returns>
        public static int[] Ordenar(int[] vet)
        {
            Ordenar(vet, 0, vet.Length - 1);
            return vet;
        }
        /// <summary>
        /// Método privado para chamada recursiva
        /// </summary>
        /// <param name="vet">Vetor informado pelo usuário</param>
        /// <param name="ini">posição inicial do vetor</param>C:\Users\usuario\Desktop\TP_ORDENACAO\TP_ORDENACAO\App.config
        /// <param name="fim">posição final do vetor</param>
        private static void Ordenar(int[] vet, int ini, int fim)
        {
            if (ini < fim)
            {
                int meio = (ini / 2) + (fim / 2);
                Ordenar(vet, ini, meio);
                Ordenar(vet, meio + 1, fim);
                Merge(vet, ini, meio, fim);
            }
        }
        /// <summary>
        /// Metodo privado para executar a organização do vetor
        /// </summary>
        /// <param name="vet">vetor informado pelo usuário</param>
        /// <param name="ini">posição inicial do vetor</param>
        /// <param name="meio">(posição final - posição incial)/2, usado para fazer as divisões do vetor</param>
        /// <param name="fim">posição final do vetor</param>
        private static void Merge(int[] vet, int ini, int meio, int fim)
        {
            int esquerda = ini;
            int direita = meio + 1;
            int[] aux = new int[(fim - ini) + 1];
            int auxpos = 0;

            while ((esquerda <= meio) && (direita <= fim))
            {
                if (vet[esquerda] < vet[direita])
                {
                    aux[auxpos] = vet[esquerda];
                    esquerda = esquerda + 1;
                }
                else
                {
                    aux[auxpos] = vet[direita];
                    direita = direita + 1;
                }
                auxpos = auxpos + 1;
            }

            if (esquerda <= meio)
            {
                while (esquerda <= meio)
                {
                    aux[auxpos] = vet[esquerda];
                    esquerda = esquerda + 1;
                    auxpos = auxpos + 1;
                }
            }

            if (direita <= fim)
            {
                while (direita <= fim)
                {
                    aux[auxpos] = vet[direita];
                    direita = direita + 1;
                    auxpos = auxpos + 1;
                }
            }

            for (int i = 0; i < aux.Length; i++)
            { vet[ini + i] = aux[i]; }
        }
    }
}
