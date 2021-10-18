using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Ajedrez
{
    public class Peon : PiezaAjedrez
    {
        public override string mover()
        {
            return "Peon solo avanza hacia adelante";
        }
    }
}
