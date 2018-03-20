namespace Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNegro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRojo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNegrita = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCursiva = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRes = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcercade,
            this.mnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuAcercade
            // 
            this.mnuAcercade.Name = "mnuAcercade";
            this.mnuAcercade.Size = new System.Drawing.Size(132, 22);
            this.mnuAcercade.Text = "Acerca de..";
            this.mnuAcercade.Click += new System.EventHandler(this.mnuAcercade_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(132, 22);
            this.mnuSalir.Text = "Salir..";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNegro,
            this.mnuAzul,
            this.mnuRojo,
            this.mnuVerde});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // mnuNegro
            // 
            this.mnuNegro.Name = "mnuNegro";
            this.mnuNegro.Size = new System.Drawing.Size(107, 22);
            this.mnuNegro.Text = "Negro";
            this.mnuNegro.Click += new System.EventHandler(this.mnuNegro_Click);
            // 
            // mnuAzul
            // 
            this.mnuAzul.Name = "mnuAzul";
            this.mnuAzul.Size = new System.Drawing.Size(107, 22);
            this.mnuAzul.Text = "Azul";
            this.mnuAzul.Click += new System.EventHandler(this.mnuAzul_Click);
            // 
            // mnuRojo
            // 
            this.mnuRojo.Name = "mnuRojo";
            this.mnuRojo.Size = new System.Drawing.Size(107, 22);
            this.mnuRojo.Text = "Rojo";
            this.mnuRojo.Click += new System.EventHandler(this.mnuRojo_Click);
            // 
            // mnuVerde
            // 
            this.mnuVerde.Name = "mnuVerde";
            this.mnuVerde.Size = new System.Drawing.Size(107, 22);
            this.mnuVerde.Text = "Verde";
            this.mnuVerde.Click += new System.EventHandler(this.mnuVerde_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimes,
            this.mnuCourier,
            this.mnuComic,
            this.mnuNegrita,
            this.mnuCursiva});
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // mnuTimes
            // 
            this.mnuTimes.Name = "mnuTimes";
            this.mnuTimes.Size = new System.Drawing.Size(174, 22);
            this.mnuTimes.Text = "Times New Roman";
            this.mnuTimes.Click += new System.EventHandler(this.mnuTimes_Click);
            // 
            // mnuCourier
            // 
            this.mnuCourier.Name = "mnuCourier";
            this.mnuCourier.Size = new System.Drawing.Size(174, 22);
            this.mnuCourier.Text = "Courier";
            this.mnuCourier.Click += new System.EventHandler(this.mnuCourier_Click);
            // 
            // mnuComic
            // 
            this.mnuComic.Name = "mnuComic";
            this.mnuComic.Size = new System.Drawing.Size(174, 22);
            this.mnuComic.Text = "Comic Sans";
            this.mnuComic.Click += new System.EventHandler(this.mnuComic_Click);
            // 
            // mnuNegrita
            // 
            this.mnuNegrita.Name = "mnuNegrita";
            this.mnuNegrita.Size = new System.Drawing.Size(174, 22);
            this.mnuNegrita.Text = "Negrita";
            this.mnuNegrita.Click += new System.EventHandler(this.negritaToolStripMenuItem_Click);
            // 
            // mnuCursiva
            // 
            this.mnuCursiva.Name = "mnuCursiva";
            this.mnuCursiva.Size = new System.Drawing.Size(174, 22);
            this.mnuCursiva.Text = "Cursiva";
            this.mnuCursiva.Click += new System.EventHandler(this.cursivaToolStripMenuItem_Click);
            // 
            // lblRes
            // 
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(13, 39);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(314, 105);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = "Usa las opciones en el menu para cambiar la apariencia de este texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 153);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNegro;
        private System.Windows.Forms.ToolStripMenuItem mnuAzul;
        private System.Windows.Forms.ToolStripMenuItem mnuRojo;
        private System.Windows.Forms.ToolStripMenuItem mnuVerde;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimes;
        private System.Windows.Forms.ToolStripMenuItem mnuCourier;
        private System.Windows.Forms.ToolStripMenuItem mnuComic;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercade;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuNegrita;
        private System.Windows.Forms.ToolStripMenuItem mnuCursiva;
        private System.Windows.Forms.Label lblRes;
    }
}

