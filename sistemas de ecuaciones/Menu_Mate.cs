using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemas_de_ecuaciones
{
    public partial class Menu_Mate : Form
    {
        public Menu_Mate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PARABOLA ventana = new PARABOLA();
            ventana.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RECTA  ventana = new RECTA();
            ventana.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CIRCUFERENCIA ventana = new CIRCUFERENCIA();
            ventana.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ELIPSE ventana = new ELIPSE();
            ventana.Show();

            this.Hide();
        }
    }
}
