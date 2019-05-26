using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoProject
{
    public static class Operacoes
    {
        #region MergeSort
        /// <summary>
        /// Método publico para o usuário Organizar um vetor
        /// </summary>
        /// <param name="vet">vetor informado pelo usuário</param>
        /// <returns>O vetor organizado</returns>
        static public int[] OrdenarQuickSort(int[] vet)
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
        #endregion

        #region Selecao
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name = "vet" > vetor informado pelo usuário</param>
        /// <returns>O vetor ordenado</returns>
        public static int[] OrdenarSelecao(int[] vet)
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
        #endregion

        #region MergeSort
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="vet">Vetor informado pelo usuário</param>
        /// <returns></returns>
        public static int[] OrdenarMergeSort(int[] vet)
        {
            OrdenarMerge(vet, 0, vet.Length - 1);
            return vet;
        }
        /// <summary>
        /// Método privado para chamada recursiva
        /// </summary>
        /// <param name="vet">Vetor informado pelo usuário</param>
        /// <param name="ini">posição inicial do vetor</param>C:\Users\usuario\Desktop\TP_ORDENACAO\TP_ORDENACAO\App.config
        /// <param name="fim">posição final do vetor</param>
        private static void OrdenarMerge(int[] vet, int ini, int fim)
        {
            if (ini < fim)
            {
                int meio = (ini / 2) + (fim / 2);
                OrdenarMerge(vet, ini, meio);
                OrdenarMerge(vet, meio + 1, fim);
                MergeSort(vet, ini, meio, fim);
            }
        }
        /// <summary>
        /// Metodo privado para executar a organização do vetor
        /// </summary>
        /// <param name="vet">vetor informado pelo usuário</param>
        /// <param name="ini">posição inicial do vetor</param>
        /// <param name="meio">(posição final - posição incial)/2, usado para fazer as divisões do vetor</param>
        /// <param name="fim">posição final do vetor</param>
        private static void MergeSort(int[] vet, int ini, int meio, int fim)
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
        #endregion

        #region BubbleSort
        /// <summary>
        /// Método estático para ordenação, utilizando o método bubbleSort
        /// </summary>
        /// <param name="vet">Vetor informado pelo usuário</param>
        /// <returns>O vetor ordenado</returns>
        public static int[] OrdenarBubbleSort(int[] vet)
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
                if (trocas == 0)
                { return vet; }
            }
            return vet;
        }
        #endregion
    }
}
