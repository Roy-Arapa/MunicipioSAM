namespace login
{
    partial class login2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login2));
            this.txtuserr = new System.Windows.Forms.TextBox();
            this.btnacceder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtpasss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuserr
            // 
            this.txtuserr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtuserr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuserr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserr.ForeColor = System.Drawing.Color.DimGray;
            this.txtuserr.Location = new System.Drawing.Point(225, 41);
            this.txtuserr.Name = "txtuserr";
            this.txtuserr.Size = new System.Drawing.Size(273, 27);
            this.txtuserr.TabIndex = 4;
            this.txtuserr.Text = "USUARIO";
            this.txtuserr.Enter += new System.EventHandler(this.txtuserr_Enter);
            this.txtuserr.Leave += new System.EventHandler(this.txtuserr_Leave);
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnacceder.FlatAppearance.BorderSize = 0;
            this.btnacceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnacceder.Location = new System.Drawing.Point(225, 125);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(273, 24);
            this.btnacceder.TabIndex = 6;
            this.btnacceder.Text = "ACCEDER";
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 189);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(62, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // txtpasss
            // 
            this.txtpasss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpasss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpasss.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasss.ForeColor = System.Drawing.Color.DimGray;
            this.txtpasss.Location = new System.Drawing.Point(225, 83);
            this.txtpasss.Name = "txtpasss";
            this.txtpasss.Size = new System.Drawing.Size(273, 27);
            this.txtpasss.TabIndex = 5;
            this.txtpasss.Text = "CONTRASEÑA";
            this.txtpasss.Enter += new System.EventHandler(this.txtpasss_Enter);
            this.txtpasss.Leave += new System.EventHandler(this.txtpasss_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "AREA";
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(527, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 6;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(506, 9);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(15, 15);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 7;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(554, 189);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpasss);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.txtuserr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login2";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login2_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuserr;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpasss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}