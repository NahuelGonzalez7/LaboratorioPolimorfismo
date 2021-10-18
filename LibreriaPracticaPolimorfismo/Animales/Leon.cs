using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public class Leon : Animal
    {
        #region Propiedades Autoimplementadas
        public string TipoLeon { get; set; }

        #endregion

        #region Constructores
        public Leon(string tipoLeon, int edad, int altura, int peso) : base(edad, altura, peso)
        {
            TipoLeon = tipoLeon;
        }

        #endregion

        #region Metodos Clase Padre

        public override string imprimir()
        {
            return base.imprimir();
        }

        public override string imprimirComida()
        {
            return "El leon come carne";
        }

        #endregion
    }
}
