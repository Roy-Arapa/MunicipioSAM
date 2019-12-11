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
    public partial class Registroderecibodeingreso : Form
    {
        public Registroderecibodeingreso()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnbuscliente_Click(object sender, EventArgs e)
        {
            Registrodeclientes rcl = new Registrodeclientes();
            rcl.Show();
        }
    }
}
