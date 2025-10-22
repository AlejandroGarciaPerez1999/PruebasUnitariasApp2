using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPruebasUnitariasApp
{
    internal class validarContrasenya
    {
        public static bool EsContrasenyaValida(string contrasenya)
        {
            if (string.IsNullOrEmpty(contrasenya)) return false;
            if (contrasenya.Length < 8) return false;
            if (!contrasenya.Contains('#')) return false;
            return true;
        }
    }
}
