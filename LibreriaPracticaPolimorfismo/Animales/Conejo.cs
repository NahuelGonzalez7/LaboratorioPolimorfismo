using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public class Conejo : Animal
    {
        #region Propiedades Autoimplementadas
        public string FrutaFavorita { get; set; }

        #endregion

        #region Constructor
        public Conejo(string frutaFavorita,int edad, int altura, int peso) : base(edad,altura,peso)
        {
            FrutaFavorita = frutaFavorita;
        }
        #endregion



        #region Metodos Clase Padre

        public override string imprimir()
        {
            return "La fruta favorita del conejo es: " + FrutaFavorita;
        }

        public override string imprimirComida()
        {
            return "El conejo es herbivoro";
        }

        #endregion
   
}
}
