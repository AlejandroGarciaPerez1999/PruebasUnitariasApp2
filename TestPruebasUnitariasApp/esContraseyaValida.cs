using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPruebasUnitariasApp;

[TestClass]
public class esContraseyaValida
{
    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiNull()
    {
        Assert.IsFalse(Program.EsContrasenyaValida(null));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiVacia()
    {
        Assert.IsFalse(Program.EsContrasenyaValida(string.Empty));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiMenosDe8()
    {
        Assert.IsFalse(Program.EsContrasenyaValida("abc#123"));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiNoTieneAlmohadilla()
    {
        Assert.IsFalse(Program.EsContrasenyaValida("abcdefghi"));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaTrue_SiCumple()
    {
        Assert.IsTrue(Program.EsContrasenyaValida("abc12345#"));
    }
}