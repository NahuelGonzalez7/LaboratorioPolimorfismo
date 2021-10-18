using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Banco
{
    public class CuentaAhorro : Cuenta
    {
        #region Constructor
        public CuentaAhorro(string idCuenta) : base(idCuenta) { }
        #endregion

        #region Metodos Clase Padre
        public override string calcularInteres()
        {
            return "Calculando el interes de Cuenta Ahorro, ID: " + IdCuenta;
        }
        #endregion
    }
}
