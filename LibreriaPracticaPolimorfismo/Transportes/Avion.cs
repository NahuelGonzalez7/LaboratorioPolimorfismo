using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Transportes
{
    public class Avion : Transporte
    {

        #region Propiedades Autoimplementadas
        public int MaxAltitud { get; set; }
        public int NroMotores { get; set; }

        #endregion

        #region Constructor
        public Avion(int maxAltitud, int nroMotores,int maxFuel,int maxNroPasajeros,string velocidad) : base (maxFuel,maxNroPasajeros,velocidad)
        {
            MaxAltitud = maxAltitud;
            NroMotores = nroMotores;
        }
        #endregion

        #region Metodos Avion
        public string descender()
        {
            return "El avion esta descendiendo";
        }

        public string ascender()
        {
            return "El avion esta ascendiendo";
        }
        #endregion

        #region Metodos Clase Padre
        public override string acelerar()
        {
            return "El avion esta acelerando";
        }

        public override string desacelerar()
        {
            return "El avion esta desacelerando";
        }
        #endregion
    }
}
