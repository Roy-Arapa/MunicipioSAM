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
    public partial class Saldopresupuestalcajachica : Form
    {
        public Saldopresupuestalcajachica()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPAO_Click(object sender, EventArgs e)
        {
            SaldoPAO spao = new SaldoPAO();
            spao.Show();
        }
    }
}
