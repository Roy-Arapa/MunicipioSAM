using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using negocios;

namespace login
{
    public partial class login2 : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public login2()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void txtuserr_Enter(object sender, EventArgs e)
        {
            if (txtuserr.Text == "USUARIO")
            {
                txtuserr.Text = "";
                txtuserr.ForeColor = Color.LightGray;
            }
        }

        private void txtuserr_Leave(object sender, EventArgs e)
        {
            if (txtuserr.Text == "")
            {
                txtuserr.Text = "USUARIO";
                txtuserr.ForeColor = Color.DimGray;
            }
        }

        private void txtpasss_Enter(object sender, EventArgs e)
        {
            if (txtpasss.Text == "CONTRASEÑA")
            {
                txtpasss.Text = "";
                txtpasss.ForeColor = Color.LightGray;
                txtpasss.UseSystemPasswordChar = true;
            }
        }

        private void txtpasss_Leave(object sender, EventArgs e)
        {
            if (txtpasss.Text == "")
            {
                txtpasss.Text = "CONTRASEÑA";
                txtpasss.ForeColor = Color.DimGray;
                txtpasss.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Para Mover la pantalla
        private void login2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (cn.conSQL1(txtuserr.Text, txtpasss.Text) == 1)
            {
                MessageBox.Show("Usuario Aceptado --> Presione ACEPTAR");
                this.Hide();

                if (txtuserr.Text == "Tesoreria")
                {
                    Tesoreria tes = new Tesoreria();
                    tes.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario NO Aceptado --> Presione ACEPTAR");
            }
        }
    }
}
