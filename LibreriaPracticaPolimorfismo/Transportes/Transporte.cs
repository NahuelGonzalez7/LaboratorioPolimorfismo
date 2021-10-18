using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Transportes
{
    public abstract class Transporte
    {
        #region Propiedades autoimplementadas
        public int MaxFuel { get; set; }
        public int MaxNroPasajeros { get; set; }
        public string Velocidad { get; set; }
        #endregion

        #region Constructores
        public Transporte(int maxFuel, int maxNroPasajeros, string velocidad)
        {
            MaxFuel = maxFuel;
            MaxNroPasajeros = maxNroPasajeros;
            Velocidad = velocidad;
        }
        #endregion

        #region Metodos
        public abstract string acelerar();
        public abstract string desacelerar();
        #endregion
    }
}
