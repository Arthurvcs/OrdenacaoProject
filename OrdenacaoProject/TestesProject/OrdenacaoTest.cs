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
            int[] QuickSortOrder = QuickSort.Ordenar(vetAleatorio);

            //Assert.
            CollectionAssert.AreEqual(arrayOrdenado, QuickSortOrder);
        }
    }
}
