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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_algebra ventana = new Menu_algebra();
            ventana.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Mate ventana = new Menu_Mate();
            ventana.Show();

            this.Hide();
        }
    }
}
