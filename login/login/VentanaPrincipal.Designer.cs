namespace login
{
    partial class VentanaPrincipal
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
            this.btncerrarp = new System.Windows.Forms.Button();
            this.btnlogistica = new System.Windows.Forms.Button();
            this.btntesoreria = new System.Windows.Forms.Button();
            this.btnpatrimonio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncerrarp
            // 
            this.btncerrarp.Location = new System.Drawing.Point(524, 226);
            this.btncerrarp.Name = "btncerrarp";
            this.btncerrarp.Size = new System.Drawing.Size(75, 23);
            this.btncerrarp.TabIndex = 0;
            this.btncerrarp.Text = "cerrar";
            this.btncerrarp.UseVisualStyleBackColor = true;
            this.btncerrarp.Click += new System.EventHandler(this.btncerrarp_Click);
            // 
            // btnlogistica
            // 
            this.btnlogistica.Location = new System.Drawing.Point(56, 97);
            this.btnlogistica.Name = "btnlogistica";
            this.btnlogistica.Size = new System.Drawing.Size(159, 35);
            this.btnlogistica.TabIndex = 1;
            this.btnlogistica.Text = "LOGISTICA";
            this.btnlogistica.UseVisualStyleBackColor = true;
            this.btnlogistica.Click += new System.EventHandler(this.btnlogistica_Click);
            // 
            // btntesoreria
            // 
            this.btntesoreria.Location = new System.Drawing.Point(221, 97);
            this.btntesoreria.Name = "btntesoreria";
            this.btntesoreria.Size = new System.Drawing.Size(159, 35);
            this.btntesoreria.TabIndex = 2;
            this.btntesoreria.Text = "TESORERIA";
            this.btntesoreria.UseVisualStyleBackColor = true;
            this.btntesoreria.Click += new System.EventHandler(this.btntesoreria_Click);
            // 
            // btnpatrimonio
            // 
            this.btnpatrimonio.Location = new System.Drawing.Point(386, 97);
            this.btnpatrimonio.Name = "btnpatrimonio";
            this.btnpatrimonio.Size = new System.Drawing.Size(159, 35);
            this.btnpatrimonio.TabIndex = 3;
            this.btnpatrimonio.Text = "PATRIMONIO";
            this.btnpatrimonio.UseVisualStyleBackColor = true;
            this.btnpatrimonio.Click += new System.EventHandler(this.btnpatrimonio_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 261);
            this.Controls.Add(this.btnpatrimonio);
            this.Controls.Add(this.btntesoreria);
            this.Controls.Add(this.btnlogistica);
            this.Controls.Add(this.btncerrarp);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncerrarp;
        private System.Windows.Forms.Button btnlogistica;
        private System.Windows.Forms.Button btntesoreria;
        private System.Windows.Forms.Button btnpatrimonio;
    }
}