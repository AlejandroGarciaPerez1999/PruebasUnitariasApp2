using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPruebasUnitariasApp
{
    [TestClass]
    public sealed class CalcularFactorial
    {
        [TestMethod]
        public void CalcularFactorial_DevolverMenosUno_SiNegativo()
        {
            long res = Program.CalcularFactorial(-1);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void CalcularFactorial_DevolverUno_SiCero()
        {
            long res = Program.CalcularFactorial(0);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_DebeSer120()
        {
            long res = Program.CalcularFactorial(5);
            Assert.AreEqual(120, res);
        }
    }
}
