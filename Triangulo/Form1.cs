using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0;
            double resultado = 0;
            if (txtAltura.Text != "" && txtBase.Text != "")
            {
                n1 = Double.Parse(txtBase.Text);
                n2 = Double.Parse(txtAltura.Text);
                resultado = (n1 * n2)/2;
                lblResultado.Text = resultado.ToString();
            }
        }
    }
}
