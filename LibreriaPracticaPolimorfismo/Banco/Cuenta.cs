using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Banco
{
    public abstract class Cuenta
    {
        #region Propiedades Autoimplementadas

        public string IdCuenta { get; set; }
        #endregion

        #region Constructores

        public Cuenta(string idCuenta)
        {
            IdCuenta = idCuenta;
        }
        #endregion

        #region Metodos Abstractos
        public abstract string calcularInteres();

        #endregion
    }
}
