using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Transportes
{
    public class Auto : Transporte
    {
        #region Propiedades Autoimplementadas
        public string Modelo { get; set; }
        #endregion

        #region Constructores
        public Auto(string modelo,int maxFuel,int maxNroPasajeros,string velocidad) : base(maxFuel,maxNroPasajeros,velocidad)
        {
            Modelo = modelo;
        }
        #endregion

        #region Metodos Clase Auto
        public string doblarAIzq()
        {
            return "El auto esta doblando a la izquierda";
        }

        public string doblarADcha()
        {
            return "El auto esta doblando a la derecha";
        }

        #endregion

        #region Metodos Clase Padre 
        public override string acelerar()
        {
            return "El auto esta acelerando ";
        }

        public override string desacelerar()
        {
            return "El auto esta desacelerando";
        }
        #endregion
    }
}
