using System;
using OrdenacaoProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesProject
{
    [TestClass]
    public class OrdenacaoTest
    {

        const int tamanho = 5;

        [TestMethod]
        public void QuickSortTest()
        {
            //Arrange.
            int[] vetAleatorio = ArrayGenerator.Random(tamanho);// Cria um vetor totalmente aleatório
            int[] arrayOrdenado = { 1, 2, 3, 4, 5 };

            //Acts.
            int[] QuickSortOrder = Operacoes.OrdenarQuickSort(vetAleatorio);

            //Assert.
            CollectionAssert.AreEqual(arrayOrdenado, QuickSortOrder);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            //Arrange.
            int[] vetAleatorio = ArrayGenerator.Random(tamanho);// Cria um vetor totalmente aleatório
            int[] arrayOrdenado = { 1, 2, 3, 4, 5 };

            //Acts.
            int[] QuickSortOrder = Operacoes.OrdenarMergeSort(vetAleatorio);

            //Assert.
            CollectionAssert.AreEqual(arrayOrdenado, QuickSortOrder);
        }

        [TestMethod]
        public void SelecaoTest()
        {
            //Arrange.
            int[] vetAleatorio = ArrayGenerator.Random(tamanho);// Cria um vetor totalmente aleatório
            int[] arrayOrdenado = { 1, 2, 3, 4, 5 };

            //Acts.
            int[] QuickSortOrder = Operacoes.OrdenarSelecao(vetAleatorio);

            //Assert.
            CollectionAssert.AreEqual(arrayOrdenado, QuickSortOrder);
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            //Arrange.
            int[] vetAleatorio = ArrayGenerator.Random(tamanho);// Cria um vetor totalmente aleatório
            int[] arrayOrdenado = { 1, 2, 3, 4, 5 };

            //Acts.
            int[] QuickSortOrder = Operacoes.OrdenarBubbleSort(vetAleatorio);

            //Assert.
            CollectionAssert.AreEqual(arrayOrdenado, QuickSortOrder);
        }

        #region Testcases
        [TestMethod]
        public void ArrayNaoEhNulo()
        {
            int[] entrada = new int[] { };

            //Assert.
            Assert.IsNotNull(entrada);

        }

        [TestMethod]
        public void EntradaNaoConfere()
        {
            double[] entradaEsperada = new double[] { };

            int[] entradaNaoEsperada = new int[] { };

            //Assert.
            Assert.AreNotEqual(entradaEsperada.GetType(), entradaNaoEsperada.GetType());
        }

        [TestMethod]
        public void VerificaEstouroDePilha()
        {
            int[] vetAleatorio = ArrayGenerator.Random(99999999);// Cria um vetor totalmente aleatório

            var exceptionThrown = false;
            try
            {
                int[] QuickSortOrder = Operacoes.OrdenarQuickSort(vetAleatorio);

            }
            catch (StackOverflowException e)
            {
                exceptionThrown = true;
                Assert.Fail();
            }
        }
        [TestMethod]
        public void InsercaoTest()
        {
            //Arrange.
            int[] vetAleatorio = ArrayGenerator.Random(50);// Cria um vetor totalmente aleatório
            int[] arrayOrdenado = ArrayGenerator.Random(50);

            //Expected Result
            Array.Sort(arrayOrdenado);

            //Acts.
            int[] Insercao = Operacoes.ordenaInsercao(vetAleatorio);

            //Assert.
            CollectionAssert.AreEqual(arrayOrdenado, Insercao);

        }


        #endregion
    }

}
