namespace CheckedListBox
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
            this.clbLenguajes = new System.Windows.Forms.CheckedListBox();
            this.lstDesplegar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clbLenguajes
            // 
            this.clbLenguajes.FormattingEnabled = true;
            this.clbLenguajes.Items.AddRange(new object[] {
            "C++",
            "Java",
            "Javascript",
            "C#",
            "Py",
            "PHP",
            "C"});
            this.clbLenguajes.Location = new System.Drawing.Point(12, 13);
            this.clbLenguajes.Name = "clbLenguajes";
            this.clbLenguajes.Size = new System.Drawing.Size(146, 154);
            this.clbLenguajes.TabIndex = 0;
            this.clbLenguajes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbLenguajes_ItemCheck);
            // 
            // lstDesplegar
            // 
            this.lstDesplegar.FormattingEnabled = true;
            this.lstDesplegar.Location = new System.Drawing.Point(181, 20);
            this.lstDesplegar.Name = "lstDesplegar";
            this.lstDesplegar.Size = new System.Drawing.Size(150, 134);
            this.lstDesplegar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 175);
            this.Controls.Add(this.lstDesplegar);
            this.Controls.Add(this.clbLenguajes);
            this.Name = "Form1";
            this.Text = "Prueba CheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbLenguajes;
        private System.Windows.Forms.ListBox lstDesplegar;
    }
}

