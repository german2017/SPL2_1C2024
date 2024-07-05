namespace TallerFrankyUi
{
    partial class FrmReparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReparacion));
            this.lstTaller = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTaller
            // 
            this.lstTaller.FormattingEnabled = true;
            this.lstTaller.Location = new System.Drawing.Point(172, 116);
            this.lstTaller.Name = "lstTaller";
            this.lstTaller.Size = new System.Drawing.Size(595, 238);
            this.lstTaller.TabIndex = 0;
            // 
            // FrmReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.lstTaller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReparacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReparacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReparacion_FormClosing);
            this.Load += new System.EventHandler(this.FrmReparacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTaller;
    }
}

