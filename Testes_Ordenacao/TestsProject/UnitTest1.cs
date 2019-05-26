using System;
using TP_ORDENACAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject
{
    [TestClass]
    public class UnitTest1
    {

        const int tamanho = 5;
        int[] arrayOrdenado = { 1, 2, 3, 4, 5 };

        [TestMethod]
        public void QuickSortTest()
        {
            //Arrange.
            int[] vetAleatorio = ArrayGenerator.Random(tamanho);// Cria um vetor totalmente aleatório

            //Acts.
            int[] QuickSortOrder = QuickSort.Ordenar(vetAleatorio);

            //Assert.
            Assert.AreEqual(arrayOrdenado, QuickSortOrder);
        }
    }
}
