using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmos.Test
{
    [TestClass]
    public class SomaTest
    {
        [TestMethod]
        public void TestarSomaValida()
        {
            var somaSimples = new Soma();
            var resultado = somaSimples.SomarDoisNumeros(5, 5);

            Assert.IsTrue(resultado == 10);
        }

        [TestMethod]
        public void TestarSomaInvalida()
        {
            var somaSimples = new Soma();
            var resultado = somaSimples.SomarDoisNumeros(5, 5);

            Assert.IsFalse(resultado == 50);
        }

        [TestMethod]
        public void TestarSomaParamsValida()
        {
            var somaParamArray = new SomaParamArray();
            var resultado = somaParamArray.SomandoIndicesDoArray(5, 5);

            Assert.IsTrue(resultado == 10);
        }

        [TestMethod]
        public void TestarSomaParamsInvalida()
        {
            var somaParamArray = new SomaParamArray();
            var resultado = somaParamArray.SomandoIndicesDoArray(5, 5);

            Assert.IsFalse(resultado == 50);
        }
    }
}
