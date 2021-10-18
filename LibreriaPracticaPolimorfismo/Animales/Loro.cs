using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public class Loro : Animal
    {
        #region Propiedades Autoimplementadas
        public string Color { get; set; }

        #endregion

        #region Constructor
        public Loro(string color, int edad, int altura, int peso) :base(edad,altura,peso)
        {
            Color = color;
        }
        #endregion

        #region Metodos

        public override string imprimir()
        {
            return "El color del loro es " + Color;
        }

        public override string imprimirComida()
        {
            return "El loro es herbivoro";
        }

        #endregion
    }
}
