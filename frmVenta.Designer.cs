namespace WindowsFormsApplication3
{
    partial class frmVenta
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
            this.txtBoxRemedio = new System.Windows.Forms.TextBox();
            this.Droga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lstBoxRemedio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBoxRemedio
            // 
            this.txtBoxRemedio.Location = new System.Drawing.Point(302, 120);
            this.txtBoxRemedio.Name = "txtBoxRemedio";
            this.txtBoxRemedio.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRemedio.TabIndex = 35;
            // 
            // Droga
            // 
            this.Droga.AutoSize = true;
            this.Droga.Location = new System.Drawing.Point(219, 123);
            this.Droga.Name = "Droga";
            this.Droga.Size = new System.Drawing.Size(49, 13);
            this.Droga.TabIndex = 34;
            this.Droga.Text = "Remedio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Codigo";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(302, 161);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantidad.TabIndex = 31;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(302, 82);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodigo.TabIndex = 30;
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(345, 202);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(75, 23);
            this.btnModificacion.TabIndex = 29;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(287, 202);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(52, 23);
            this.btnBaja.TabIndex = 28;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(213, 202);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(59, 23);
            this.btnAlta.TabIndex = 27;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lstBoxRemedio
            // 
            this.lstBoxRemedio.FormattingEnabled = true;
            this.lstBoxRemedio.Location = new System.Drawing.Point(21, 26);
            this.lstBoxRemedio.Name = "lstBoxRemedio";
            this.lstBoxRemedio.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxRemedio.Size = new System.Drawing.Size(175, 199);
            this.lstBoxRemedio.TabIndex = 26;
            this.lstBoxRemedio.SelectedIndexChanged += new System.EventHandler(this.lstBoxRemedio_SelectedIndexChanged);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 249);
            this.Controls.Add(this.txtBoxRemedio);
            this.Controls.Add(this.Droga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lstBoxRemedio);
            this.Name = "frmVenta";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxRemedio;
        private System.Windows.Forms.Label Droga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ListBox lstBoxRemedio;
    }
}