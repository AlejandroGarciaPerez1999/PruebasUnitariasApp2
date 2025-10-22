using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPruebasUnitariasApp;

[TestClass]
public class esContraseyaValida
{
    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiNull()
    {
        Assert.IsFalse(validarContrasenya.EsContrasenyaValida(null));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiVacia()
    {
        Assert.IsFalse(validarContrasenya.EsContrasenyaValida(string.Empty));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiMenosDe8()
    {
        Assert.IsFalse(validarContrasenya.EsContrasenyaValida("abc#123"));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaFalse_SiNoTieneAlmohadilla()
    {
        Assert.IsFalse(validarContrasenya.EsContrasenyaValida("abcdefghi"));
    }

    [TestMethod]
    public void EsContrasenyaValida_DeberiaTrue_SiCumple()
    {
        Assert.IsTrue(validarContrasenya.EsContrasenyaValida("abc12345#"));
    }
}