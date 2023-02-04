using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculobutton1_Click(object sender, EventArgs e)
        {
            parEimpar();
            positivoOnegativo();

        }

        private void parEimpar()
        {
            decimal num = 0;
            num = Convert.ToDecimal(numerotextBox1.Text);

            if ((num % 2) == 0)
            {
                MessageBox.Show("Es un número par");
            }
            else
            {
                MessageBox.Show("Es un número impar");
            }
        }

        private void positivoOnegativo()
        {
            decimal num = 0;
            num = Convert.ToDecimal(numerotextBox1.Text);
            if (num >= 1)
            {
                MessageBox.Show("Es un número positivo");

            }
            else if (num <= -1)
            {
                MessageBox.Show("Es un número negativo");

            }
        }
    }
}
