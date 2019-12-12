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
    public partial class AfectacionPresupuestal : Form
    {
        public AfectacionPresupuestal()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            Detalledeafectacionpresupuestal dap = new Detalledeafectacionpresupuestal();
            dap.Show();
        }
    }
}
