using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Ajedrez
{
    public class Torre : PiezaAjedrez
    {
        public override string mover()
        {
            return "La torre puede moverse en línea recta ";
        }
    }
}
