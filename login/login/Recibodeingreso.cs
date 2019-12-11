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
    public partial class Recibodeingreso : Form
    {
        public Recibodeingreso()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Registroderecibodeingreso ri = new Registroderecibodeingreso();
            ri.Show();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            SeleccionReporte sr = new SeleccionReporte();
            sr.Show();
        }
    }
}
