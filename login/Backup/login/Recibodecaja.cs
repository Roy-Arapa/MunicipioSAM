﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Recibodecaja : Form
    {
        public Recibodecaja()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Registroderecibodecaja rc = new Registroderecibodecaja();
            rc.Show();
        }
    }
}
