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
    public partial class Tesoreria : Form
    {
        public Tesoreria()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal v1 = new VentanaPrincipal();
            v1.Show();
        }

        private void btnmenu2recibocaja_Click(object sender, EventArgs e)
        {
            Recibodecaja caja = new Recibodecaja();
            caja.Show();
        }

        private void btnmenu2reciboingreso_Click(object sender, EventArgs e)
        {
            Recibodeingreso ingreso = new Recibodeingreso();
            ingreso.Show();
        }

        private void btnafecppre_Click(object sender, EventArgs e)
        {
            AfectacionPresupuestal ap = new AfectacionPresupuestal();
            ap.Show();
        }

        private void btnsalprecachi_Click(object sender, EventArgs e)
        {
            Saldopresupuestalcajachica caja = new Saldopresupuestalcajachica();
            caja.Show();
        }
    }
}
