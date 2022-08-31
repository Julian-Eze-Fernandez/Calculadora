using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmInicio : Form
    {
        Calculadora calculadora = new Calculadora();

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            calculadora.Num1 = Convert.ToDouble(TxtOperando1.Text);
            calculadora.Num2 = Convert.ToDouble(TxtOperando2.Text);

            double res = calculadora.Operar("+"); 
            lblResultado.Text = res.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            calculadora.Num1 = Convert.ToDouble(TxtOperando1.Text);
            calculadora.Num2 = Convert.ToDouble(TxtOperando2.Text);

            double res = calculadora.Operar("-");
            lblResultado.Text = res.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            calculadora.Num1 = Convert.ToDouble(TxtOperando1.Text);
            calculadora.Num2 = Convert.ToDouble(TxtOperando2.Text);

            double res = calculadora.Operar("*");
            lblResultado.Text = res.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            calculadora.Num1 = Convert.ToDouble(TxtOperando1.Text);
            calculadora.Num2 = Convert.ToDouble(TxtOperando2.Text);

            double res = calculadora.Operar("/");
            lblResultado.Text = res.ToString();
        }
    }
}
