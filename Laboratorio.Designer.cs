namespace WindowsFormsApplication3
{
    partial class Laboratorio
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
            this.lstBoxInfo = new System.Windows.Forms.ListBox();
            this.btnAbmUser = new System.Windows.Forms.Button();
            this.btnAbmDroga = new System.Windows.Forms.Button();
            this.btnAbmRemedio = new System.Windows.Forms.Button();
            this.btnAbmVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRecaudacion = new System.Windows.Forms.TextBox();
            this.txtBoxPromedio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDroga8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxLessUsed = new System.Windows.Forms.TextBox();
            this.txtBoxExpensive = new System.Windows.Forms.TextBox();
            this.txtBoxCheapest = new System.Windows.Forms.TextBox();
            this.btnShowValores = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxInfo
            // 
            this.lstBoxInfo.FormattingEnabled = true;
            this.lstBoxInfo.Location = new System.Drawing.Point(27, 160);
            this.lstBoxInfo.Name = "lstBoxInfo";
            this.lstBoxInfo.Size = new System.Drawing.Size(239, 277);
            this.lstBoxInfo.TabIndex = 2;
            // 
            // btnAbmUser
            // 
            this.btnAbmUser.Location = new System.Drawing.Point(27, 38);
            this.btnAbmUser.Name = "btnAbmUser";
            this.btnAbmUser.Size = new System.Drawing.Size(75, 23);
            this.btnAbmUser.TabIndex = 3;
            this.btnAbmUser.Text = "Usuarios";
            this.btnAbmUser.UseVisualStyleBackColor = true;
            this.btnAbmUser.Click += new System.EventHandler(this.btnAbmUser_Click);
            // 
            // btnAbmDroga
            // 
            this.btnAbmDroga.Location = new System.Drawing.Point(124, 38);
            this.btnAbmDroga.Name = "btnAbmDroga";
            this.btnAbmDroga.Size = new System.Drawing.Size(75, 23);
            this.btnAbmDroga.TabIndex = 4;
            this.btnAbmDroga.Text = "Drogas";
            this.btnAbmDroga.UseVisualStyleBackColor = true;
            this.btnAbmDroga.Click += new System.EventHandler(this.btnAbmDroga_Click);
            // 
            // btnAbmRemedio
            // 
            this.btnAbmRemedio.Location = new System.Drawing.Point(27, 95);
            this.btnAbmRemedio.Name = "btnAbmRemedio";
            this.btnAbmRemedio.Size = new System.Drawing.Size(75, 23);
            this.btnAbmRemedio.TabIndex = 5;
            this.btnAbmRemedio.Text = "Remedios";
            this.btnAbmRemedio.UseVisualStyleBackColor = true;
            this.btnAbmRemedio.Click += new System.EventHandler(this.btnAbmRemedio_Click);
            // 
            // btnAbmVenta
            // 
            this.btnAbmVenta.Location = new System.Drawing.Point(124, 95);
            this.btnAbmVenta.Name = "btnAbmVenta";
            this.btnAbmVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAbmVenta.TabIndex = 6;
            this.btnAbmVenta.Text = "Ventas";
            this.btnAbmVenta.UseVisualStyleBackColor = true;
            this.btnAbmVenta.Click += new System.EventHandler(this.btnAbmVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recaudacion Total";
            // 
            // txtBoxRecaudacion
            // 
            this.txtBoxRecaudacion.Location = new System.Drawing.Point(442, 382);
            this.txtBoxRecaudacion.Name = "txtBoxRecaudacion";
            this.txtBoxRecaudacion.Size = new System.Drawing.Size(158, 20);
            this.txtBoxRecaudacion.TabIndex = 8;
            // 
            // txtBoxPromedio
            // 
            this.txtBoxPromedio.Location = new System.Drawing.Point(442, 346);
            this.txtBoxPromedio.Name = "txtBoxPromedio";
            this.txtBoxPromedio.Size = new System.Drawing.Size(158, 20);
            this.txtBoxPromedio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Precio Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remedio que mas usa droga 8";
            // 
            // txtBoxDroga8
            // 
            this.txtBoxDroga8.Location = new System.Drawing.Point(442, 305);
            this.txtBoxDroga8.Name = "txtBoxDroga8";
            this.txtBoxDroga8.Size = new System.Drawing.Size(158, 20);
            this.txtBoxDroga8.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Droga menos usada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Droga mas cara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Remedio mas barato";
            // 
            // txtBoxLessUsed
            // 
            this.txtBoxLessUsed.Location = new System.Drawing.Point(442, 264);
            this.txtBoxLessUsed.Name = "txtBoxLessUsed";
            this.txtBoxLessUsed.Size = new System.Drawing.Size(158, 20);
            this.txtBoxLessUsed.TabIndex = 16;
            // 
            // txtBoxExpensive
            // 
            this.txtBoxExpensive.Location = new System.Drawing.Point(442, 231);
            this.txtBoxExpensive.Name = "txtBoxExpensive";
            this.txtBoxExpensive.Size = new System.Drawing.Size(158, 20);
            this.txtBoxExpensive.TabIndex = 17;
            // 
            // txtBoxCheapest
            // 
            this.txtBoxCheapest.Location = new System.Drawing.Point(442, 197);
            this.txtBoxCheapest.Name = "txtBoxCheapest";
            this.txtBoxCheapest.Size = new System.Drawing.Size(158, 20);
            this.txtBoxCheapest.TabIndex = 18;
            // 
            // btnShowValores
            // 
            this.btnShowValores.Location = new System.Drawing.Point(291, 23);
            this.btnShowValores.Name = "btnShowValores";
            this.btnShowValores.Size = new System.Drawing.Size(309, 23);
            this.btnShowValores.TabIndex = 19;
            this.btnShowValores.Text = "Recaudacion por cada remedio";
            this.btnShowValores.UseVisualStyleBackColor = true;
            this.btnShowValores.Click += new System.EventHandler(this.btnShowValores_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(291, 52);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(309, 23);
            this.btnPromedio.TabIndex = 20;
            this.btnPromedio.Text = "Valor de cada remedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(291, 81);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(309, 23);
            this.btnPorcentaje.TabIndex = 21;
            this.btnPorcentaje.Text = "Porcentaje que representa  cada remedio  en recaudacion";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(291, 423);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(309, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refrescar informacion";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 458);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnShowValores);
            this.Controls.Add(this.txtBoxCheapest);
            this.Controls.Add(this.txtBoxExpensive);
            this.Controls.Add(this.txtBoxLessUsed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxDroga8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPromedio);
            this.Controls.Add(this.txtBoxRecaudacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbmVenta);
            this.Controls.Add(this.btnAbmRemedio);
            this.Controls.Add(this.btnAbmDroga);
            this.Controls.Add(this.btnAbmUser);
            this.Controls.Add(this.lstBoxInfo);
            this.Name = "Laboratorio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox lstBoxInfo;
        private System.Windows.Forms.Button btnAbmUser;
        private System.Windows.Forms.Button btnAbmDroga;
        private System.Windows.Forms.Button btnAbmRemedio;
        private System.Windows.Forms.Button btnAbmVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRecaudacion;
        private System.Windows.Forms.TextBox txtBoxPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDroga8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxLessUsed;
        private System.Windows.Forms.TextBox txtBoxExpensive;
        private System.Windows.Forms.TextBox txtBoxCheapest;
        private System.Windows.Forms.Button btnShowValores;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnRefresh;
    }
}

