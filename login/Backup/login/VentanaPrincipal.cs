using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btncerrarp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogistica_Click(object sender, EventArgs e)
        {
            login2 l2 = new login2();
            l2.Show();
        }

        private void btntesoreria_Click(object sender, EventArgs e)
        {
            this.Hide();
            login2 l2 = new login2();
            l2.Show();
        }

        private void btnpatrimonio_Click(object sender, EventArgs e)
        {
            login2 l2 = new login2();
            l2.Show();
        }
    }
}
