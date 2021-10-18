using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public abstract class Animal
    {
        #region Propiedades Autoimplementadas
        private int Edad { get; }

        private int Altura { get; }
        private int Peso  { get; }
        #endregion

        #region Constructor

        public Animal(int edad, int altura, int peso)
        {
            Edad = edad;
            Altura = altura;
            Peso = peso;
        }
        #endregion

        #region Metodos
        public virtual string imprimir()
        {
            return "La edad del animal es: " + Edad.ToString() + "La altura del animal es: " + Altura.ToString() + "El peso del animal es: " + Peso.ToString();
        }

        public abstract string imprimirComida();

        #endregion
    }
}
