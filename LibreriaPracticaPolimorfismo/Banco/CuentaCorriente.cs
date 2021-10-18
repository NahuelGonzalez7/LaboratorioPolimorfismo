using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Banco
{
    public class CuentaCorriente : Cuenta
    {
        #region Constructor
        public CuentaCorriente(string idCuenta) : base(idCuenta) { }

        #endregion

        #region Metodos Clase Padre
        public override string calcularInteres()
        {
            return "Calculando el interes de cuenta corriente, ID:" + IdCuenta;
        }
        #endregion
    }
}
