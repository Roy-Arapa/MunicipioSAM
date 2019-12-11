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
    public partial class Registroderecibodecaja : Form
    {
        public Registroderecibodecaja()
        {
            InitializeComponent();
        }

        private void btnbuscliente_Click(object sender, EventArgs e)
        {
            Registrodeclientes rc = new Registrodeclientes();
            rc.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
