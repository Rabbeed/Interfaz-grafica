namespace TreeView
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
            this.treDirectorio = new System.Windows.Forms.TreeView();
            this.lblNodos = new System.Windows.Forms.Label();
            this.lstNodos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // treDirectorio
            // 
            this.treDirectorio.Location = new System.Drawing.Point(12, 12);
            this.treDirectorio.Name = "treDirectorio";
            this.treDirectorio.Size = new System.Drawing.Size(177, 180);
            this.treDirectorio.TabIndex = 0;
            this.treDirectorio.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treDirectorio_AfterSelect_1);
            // 
            // lblNodos
            // 
            this.lblNodos.Location = new System.Drawing.Point(207, 162);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(85, 32);
            this.lblNodos.TabIndex = 2;
            // 
            // lstNodos
            // 
            this.lstNodos.FormattingEnabled = true;
            this.lstNodos.Location = new System.Drawing.Point(210, 12);
            this.lstNodos.Name = "lstNodos";
            this.lstNodos.Size = new System.Drawing.Size(179, 147);
            this.lstNodos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 203);
            this.Controls.Add(this.lblNodos);
            this.Controls.Add(this.lstNodos);
            this.Controls.Add(this.treDirectorio);
            this.Name = "Form1";
            this.Text = "Prueba TreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treDirectorio;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.ListBox lstNodos;
    }
}

