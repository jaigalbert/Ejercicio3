using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FactorialDP : Form
    {
        public FactorialDP()
        {
            InitializeComponent();
        }
        //Calculo de factorial
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (esEntero(txtNumero.Text))
            {
                int Numero = Int32.Parse(txtNumero.Text), Resultado=1;
                for (int i = Numero ; i > 0; --i) {
                    Resultado = (Resultado * i);
                }
                txtResultado.Text = Resultado.ToString();
                MessageBox.Show("El factorial de "+txtNumero.Text+" es igual a "+txtResultado.Text);
            }
            else {
                MessageBox.Show("El valor capturado no es entero");
            }
        }
        //Validacion de entero para obtener factorial
        public bool esEntero(string numero)
        {
            try
            {
                Int32.Parse(numero);
                return true;

            }
            catch
            {
                return false;
            }
        }

    }
    
}
