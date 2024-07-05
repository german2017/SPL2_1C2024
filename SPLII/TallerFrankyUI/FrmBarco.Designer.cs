namespace TallerFrankyUi
{
    partial class FrmBarco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBarco));
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(29, 148);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(147, 23);
            this.cmbTipo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtNombre.Location = new System.Drawing.Point(29, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(26, 32);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(78, 24);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(26, 115);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(47, 24);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(29, 229);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(147, 23);
            this.cmbOperacion.TabIndex = 5;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacion.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblOperacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOperacion.Location = new System.Drawing.Point(26, 199);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(97, 24);
            this.lblOperacion.TabIndex = 7;
            this.lblOperacion.Text = "Operacion";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCargar.Location = new System.Drawing.Point(29, 277);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(147, 27);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmBarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(215, 316);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBarco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBarco";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnCargar;
    }
}