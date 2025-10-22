using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPruebasUnitariasApp
{
    [TestClass]
    public sealed class CalcularFactorial
    {
        [TestMethod]
        public void CalcularFactorial_DevolverMenosUno_SiNegativo()
        {
            long res = validadorfactorial.CalcularFactorial(-1);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void CalcularFactorial_DevolverUno_SiCero()
        {
            long res = validadorfactorial.CalcularFactorial(0);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_DebeSer120()
        {
            long res = validadorfactorial.CalcularFactorial(5);
            Assert.AreEqual(120, res);
        }
    }
}
