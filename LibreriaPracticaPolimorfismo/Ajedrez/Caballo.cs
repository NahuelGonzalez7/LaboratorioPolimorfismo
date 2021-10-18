using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Ajedrez
{
    public class Caballo : PiezaAjedrez
    {
        public override string mover()
        {
            return "Caballo se desplaza en forma de L";
        }
    }
}
