using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoProject
{
  public static  class ArrayGenerator
    {

        public static int[] Crescente(int tamanho)
        {
            int[] aux = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                aux[i] = (i + 1);
            }
            return aux;
        }

        public static int[] Decrescente(int tamanho)
        {
            int[] aux = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                aux[i] = tamanho - (i + 1);
            }
            return aux;
        }

        public static int[] SemiOrdenado(int tamanho)
        {
            Random aleat = new Random(42);

            int[] aux = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                aux[i] = (i + 1);
            }

            for (int i = 0; i < (tamanho / 20); i++)
            {
                int p1 = aleat.Next(0, tamanho);
                int p2 = aleat.Next(0, tamanho);
                int temp = aux[p1];
                aux[p1] = aux[p2];
                aux[p2] = temp;
            }
            return aux;
        }

        public static int[] Random(int tamanho)
        {
            //Random aleat = new Random(42);

            //int[] aux = new int[tamanho];
            //for (int i = 0; i < tamanho; i++)
            //{
            //    aux[i] = aleat.Next(0, tamanho);
            //}
            int[] aux = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                aux[i] = (i + 1);
            }
            aux = Shuffle(aux);

            return aux;

        }

        public static long[] NewRandom(long tamanho)
        {
            //Random aleat = new Random(42);

            //int[] aux = new int[tamanho];
            //for (int i = 0; i < tamanho; i++)
            //{
            //    aux[i] = aleat.Next(0, tamanho);
            //}
            long[] aux = new long[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                aux[i] = (i + 1);
            }
            aux = newShuffle(aux);

            return aux;

        }

        static int[] Shuffle(int [] array)
        {
            Random _random = new Random();

            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                int j = random.Next(i); 
                                        
                int tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }

        static long[] newShuffle(long[] array)
        {
            Random _random = new Random();

            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                int j = random.Next(i);

                long tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }
    }
}
