using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPruebasUnitariasApp
{
    internal class validarContrasenya
    {
        public static bool EsContrasenyaValida(string contrasenya) =>
            !string.IsNullOrEmpty(contrasenya)
            && contrasenya.Length >= 8
            && contrasenya.Contains('#');
    }
}
