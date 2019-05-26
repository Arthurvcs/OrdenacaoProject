using System;
using TP_ORDENACAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        int[] vetCrescente, vetDecrescente, vetSemiOrdenado, vetAleatorio;

       vetCrescente = ArrayGenerator.Crescente(tamanho);
       vetDecrescente = ArrayGenerator.Decrescente(tamanho);
       vetSemiOrdenado = ArrayGenerator.SemiOrdenado(tamanho);
       vetAleatorio = ArrayGenerator.Random(tamanho);

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
