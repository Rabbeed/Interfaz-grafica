namespace TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbtNegro = new System.Windows.Forms.RadioButton();
            this.rbtVerde = new System.Windows.Forms.RadioButton();
            this.rbtRojo = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbt20 = new System.Windows.Forms.RadioButton();
            this.rbt16 = new System.Windows.Forms.RadioButton();
            this.rbt12 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblRes = new System.Windows.Forms.Label();
            this.rbtM1 = new System.Windows.Forms.RadioButton();
            this.rbtM2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbtNegro);
            this.tabPage1.Controls.Add(this.rbtVerde);
            this.tabPage1.Controls.Add(this.rbtRojo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbtNegro
            // 
            this.rbtNegro.AutoSize = true;
            this.rbtNegro.Location = new System.Drawing.Point(31, 116);
            this.rbtNegro.Name = "rbtNegro";
            this.rbtNegro.Size = new System.Drawing.Size(54, 17);
            this.rbtNegro.TabIndex = 2;
            this.rbtNegro.TabStop = true;
            this.rbtNegro.Text = "Negro";
            this.rbtNegro.UseVisualStyleBackColor = true;
            this.rbtNegro.CheckedChanged += new System.EventHandler(this.rbtNegro_CheckedChanged_1);
            // 
            // rbtVerde
            // 
            this.rbtVerde.AutoSize = true;
            this.rbtVerde.Location = new System.Drawing.Point(31, 189);
            this.rbtVerde.Name = "rbtVerde";
            this.rbtVerde.Size = new System.Drawing.Size(53, 17);
            this.rbtVerde.TabIndex = 1;
            this.rbtVerde.TabStop = true;
            this.rbtVerde.Text = "Verde";
            this.rbtVerde.UseVisualStyleBackColor = true;
            this.rbtVerde.CheckedChanged += new System.EventHandler(this.rbtVerde_CheckedChanged_1);
            // 
            // rbtRojo
            // 
            this.rbtRojo.AutoSize = true;
            this.rbtRojo.Location = new System.Drawing.Point(31, 45);
            this.rbtRojo.Name = "rbtRojo";
            this.rbtRojo.Size = new System.Drawing.Size(47, 17);
            this.rbtRojo.TabIndex = 0;
            this.rbtRojo.TabStop = true;
            this.rbtRojo.Text = "Rojo";
            this.rbtRojo.UseVisualStyleBackColor = true;
            this.rbtRojo.CheckedChanged += new System.EventHandler(this.rbtRojo_CheckedChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rbt20);
            this.tabPage2.Controls.Add(this.rbt16);
            this.tabPage2.Controls.Add(this.rbt12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tamaño";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbt20
            // 
            this.rbt20.AutoSize = true;
            this.rbt20.Location = new System.Drawing.Point(33, 182);
            this.rbt20.Name = "rbt20";
            this.rbt20.Size = new System.Drawing.Size(37, 17);
            this.rbt20.TabIndex = 2;
            this.rbt20.TabStop = true;
            this.rbt20.Text = "20";
            this.rbt20.UseVisualStyleBackColor = true;
            this.rbt20.CheckedChanged += new System.EventHandler(this.rbt20_CheckedChanged);
            // 
            // rbt16
            // 
            this.rbt16.AutoSize = true;
            this.rbt16.Location = new System.Drawing.Point(33, 117);
            this.rbt16.Name = "rbt16";
            this.rbt16.Size = new System.Drawing.Size(37, 17);
            this.rbt16.TabIndex = 1;
            this.rbt16.TabStop = true;
            this.rbt16.Text = "16";
            this.rbt16.UseVisualStyleBackColor = true;
            this.rbt16.CheckedChanged += new System.EventHandler(this.rbt16_CheckedChanged);
            // 
            // rbt12
            // 
            this.rbt12.AutoSize = true;
            this.rbt12.Location = new System.Drawing.Point(33, 55);
            this.rbt12.Name = "rbt12";
            this.rbt12.Size = new System.Drawing.Size(37, 17);
            this.rbt12.TabIndex = 0;
            this.rbt12.TabStop = true;
            this.rbt12.Text = "12";
            this.rbt12.UseVisualStyleBackColor = true;
            this.rbt12.CheckedChanged += new System.EventHandler(this.rbt12_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rbtM2);
            this.tabPage3.Controls.Add(this.rbtM1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(497, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mensaje";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(497, 256);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Acerca de";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(13, 315);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(52, 18);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = "Prueba";
            // 
            // rbtM1
            // 
            this.rbtM1.AutoSize = true;
            this.rbtM1.Location = new System.Drawing.Point(30, 56);
            this.rbtM1.Name = "rbtM1";
            this.rbtM1.Size = new System.Drawing.Size(51, 17);
            this.rbtM1.TabIndex = 0;
            this.rbtM1.TabStop = true;
            this.rbtM1.Text = "Adios";
            this.rbtM1.UseVisualStyleBackColor = true;
            this.rbtM1.CheckedChanged += new System.EventHandler(this.rbtM1_CheckedChanged);
            // 
            // rbtM2
            // 
            this.rbtM2.AutoSize = true;
            this.rbtM2.Location = new System.Drawing.Point(30, 159);
            this.rbtM2.Name = "rbtM2";
            this.rbtM2.Size = new System.Drawing.Size(78, 17);
            this.rbtM2.TabIndex = 1;
            this.rbtM2.TabStop = true;
            this.rbtM2.Text = "Bienvenido";
            this.rbtM2.UseVisualStyleBackColor = true;
            this.rbtM2.CheckedChanged += new System.EventHandler(this.rbtM2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Los tabs son usados para organizar controles y preservar el espacio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 367);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PruebaTab";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.RadioButton rbtNegro;
        private System.Windows.Forms.RadioButton rbtVerde;
        private System.Windows.Forms.RadioButton rbtRojo;
        private System.Windows.Forms.RadioButton rbt20;
        private System.Windows.Forms.RadioButton rbt16;
        private System.Windows.Forms.RadioButton rbt12;
        private System.Windows.Forms.RadioButton rbtM2;
        private System.Windows.Forms.RadioButton rbtM1;
        private System.Windows.Forms.Label label1;
    }
}

