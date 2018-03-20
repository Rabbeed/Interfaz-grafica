namespace LinkLabel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDrive = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblBlocNotas = new System.Windows.Forms.LinkLabel();
            this.lblSitioWeb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(21, 20);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(116, 13);
            this.lblDrive.TabIndex = 0;
            this.lblDrive.TabStop = true;
            this.lblDrive.Text = "Examinar disco local C:";
            this.lblDrive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDrive_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visitar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblBlocNotas
            // 
            this.lblBlocNotas.AutoSize = true;
            this.lblBlocNotas.Location = new System.Drawing.Point(21, 88);
            this.lblBlocNotas.Name = "lblBlocNotas";
            this.lblBlocNotas.Size = new System.Drawing.Size(95, 13);
            this.lblBlocNotas.TabIndex = 2;
            this.lblBlocNotas.TabStop = true;
            this.lblBlocNotas.Text = "Abrir bloc de notas";
            this.lblBlocNotas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBlocNotas_LinkClicked);
            // 
            // lblSitioWeb
            // 
            this.lblSitioWeb.AutoSize = true;
            this.lblSitioWeb.LinkColor = System.Drawing.Color.Black;
            this.lblSitioWeb.Location = new System.Drawing.Point(55, 54);
            this.lblSitioWeb.Name = "lblSitioWeb";
            this.lblSitioWeb.Size = new System.Drawing.Size(88, 13);
            this.lblSitioWeb.TabIndex = 4;
            this.lblSitioWeb.TabStop = true;
            this.lblSitioWeb.Text = "www.uaz.edu.mx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 124);
            this.Controls.Add(this.lblSitioWeb);
            this.Controls.Add(this.lblBlocNotas);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblDrive);
            this.Name = "Form1";
            this.Text = "Prueba LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblDrive;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblBlocNotas;
        private System.Windows.Forms.LinkLabel lblSitioWeb;
    }
}

