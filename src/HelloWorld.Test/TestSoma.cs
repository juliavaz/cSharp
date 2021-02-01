using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Test
{
    [TestClass]
    public class TestSoma
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
    }
}
