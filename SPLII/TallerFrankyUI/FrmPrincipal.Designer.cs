namespace TallerFrankyUi
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnReparar = new System.Windows.Forms.Button();
            this.btnCargarBarco = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReparar
            // 
            this.btnReparar.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnReparar.Location = new System.Drawing.Point(53, 119);
            this.btnReparar.Name = "btnReparar";
            this.btnReparar.Size = new System.Drawing.Size(247, 40);
            this.btnReparar.TabIndex = 0;
            this.btnReparar.Text = "Reparar";
            this.btnReparar.UseVisualStyleBackColor = true;
            this.btnReparar.Click += new System.EventHandler(this.btnReparar_Click);
            // 
            // btnCargarBarco
            // 
            this.btnCargarBarco.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnCargarBarco.Location = new System.Drawing.Point(53, 26);
            this.btnCargarBarco.Name = "btnCargarBarco";
            this.btnCargarBarco.Size = new System.Drawing.Size(247, 40);
            this.btnCargarBarco.TabIndex = 1;
            this.btnCargarBarco.Text = "Cargar Barco";
            this.btnCargarBarco.UseVisualStyleBackColor = true;
            this.btnCargarBarco.Click += new System.EventHandler(this.btnCargarBarco_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnGuardar.Location = new System.Drawing.Point(53, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(247, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 271);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargarBarco);
            this.Controls.Add(this.btnReparar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReparar;
        private System.Windows.Forms.Button btnCargarBarco;
        private System.Windows.Forms.Button btnGuardar;
    }
}