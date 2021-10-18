using LibreriaPracticaPolimorfismo.Ajedrez;
using LibreriaPracticaPolimorfismo.Animales;
using LibreriaPracticaPolimorfismo.Banco;
using LibreriaPracticaPolimorfismo.Transportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemoAjedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();

            MessageBox.Show(peon.mover());

            Caballo caballo = new Caballo();

            MessageBox.Show(caballo.mover());

            Torre torre = new Torre();

            MessageBox.Show(torre.mover());
        }

        private void btnInstanciasTransporte_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto("BMW", 30, 5, "220 KM/h");

            MessageBox.Show("\n " + auto.acelerar() + "\n " + auto.desacelerar() + "\n " + auto.doblarADcha() + "\n " + auto.doblarAIzq());

            Avion avion = new Avion(2200, 4, 500, 200, "700 KM /H");

            MessageBox.Show("\n " + avion.acelerar() + "\n " + avion.desacelerar() + "\n " + avion.ascender() + "\n " + avion.ascender());
        }

        private void btnCrearAnimales_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon("Leon del congod", 10, 2, 220);

            MessageBox.Show(leon.imprimir() + "\n " + leon.imprimirComida());

            Conejo conejo = new Conejo("manzana", 2, 20, 2);

            MessageBox.Show(conejo.imprimir() + "\n " + conejo.imprimirComida());

            Loro loro = new Loro("verde y amarillo", 1, 10, 1);

            MessageBox.Show(loro.imprimir() + "\n " + loro.imprimirComida());

        }

        private void btnCrearInstanciaCuenta_Click(object sender, EventArgs e)
        {
            CuentaCorriente cuentaCorriente1 = new CuentaCorriente("1FX8");

            MessageBox.Show(cuentaCorriente1.calcularInteres());

            CuentaAhorro cuentaAhorro1 = new CuentaAhorro("1CA99");

            MessageBox.Show(cuentaAhorro1.calcularInteres());
        }
    }
}
