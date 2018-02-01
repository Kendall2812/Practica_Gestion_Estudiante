namespace WindowsFormsApp1
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
            this.txtResidencia = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Fecha_Nacer = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResidencia2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtCedula2 = new System.Windows.Forms.TextBox();
            this.Fecha_Nacer2 = new System.Windows.Forms.DateTimePicker();
            this.Lista_Estudiante = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(57, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResidencia);
            this.tabPage1.Controls.Add(this.txtCedula);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.Fecha_Nacer);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar Estudiantes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResidencia
            // 
            this.txtResidencia.Location = new System.Drawing.Point(167, 193);
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(362, 27);
            this.txtResidencia.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(167, 42);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(362, 27);
            this.txtCedula.TabIndex = 7;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(362, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // Fecha_Nacer
            // 
            this.Fecha_Nacer.Location = new System.Drawing.Point(167, 150);
            this.Fecha_Nacer.Name = "Fecha_Nacer";
            this.Fecha_Nacer.Size = new System.Drawing.Size(362, 27);
            this.Fecha_Nacer.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(189, 285);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 31);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Ingresar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Residencia :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResidencia2);
            this.tabPage2.Controls.Add(this.txtNombre2);
            this.tabPage2.Controls.Add(this.txtCedula2);
            this.tabPage2.Controls.Add(this.Fecha_Nacer2);
            this.tabPage2.Controls.Add(this.Lista_Estudiante);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cosultar Estudiantes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResidencia2
            // 
            this.txtResidencia2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResidencia2.Location = new System.Drawing.Point(172, 235);
            this.txtResidencia2.Name = "txtResidencia2";
            this.txtResidencia2.ReadOnly = true;
            this.txtResidencia2.Size = new System.Drawing.Size(362, 27);
            this.txtResidencia2.TabIndex = 9;
            // 
            // txtNombre2
            // 
            this.txtNombre2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre2.Location = new System.Drawing.Point(172, 125);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.ReadOnly = true;
            this.txtNombre2.Size = new System.Drawing.Size(362, 27);
            this.txtNombre2.TabIndex = 8;
            // 
            // txtCedula2
            // 
            this.txtCedula2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCedula2.Location = new System.Drawing.Point(172, 72);
            this.txtCedula2.Name = "txtCedula2";
            this.txtCedula2.ReadOnly = true;
            this.txtCedula2.Size = new System.Drawing.Size(362, 27);
            this.txtCedula2.TabIndex = 7;
            // 
            // Fecha_Nacer2
            // 
            this.Fecha_Nacer2.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLight;
            this.Fecha_Nacer2.Enabled = false;
            this.Fecha_Nacer2.Location = new System.Drawing.Point(172, 180);
            this.Fecha_Nacer2.Name = "Fecha_Nacer2";
            this.Fecha_Nacer2.Size = new System.Drawing.Size(362, 27);
            this.Fecha_Nacer2.TabIndex = 6;
            // 
            // Lista_Estudiante
            // 
            this.Lista_Estudiante.FormattingEnabled = true;
            this.Lista_Estudiante.Location = new System.Drawing.Point(172, 18);
            this.Lista_Estudiante.Name = "Lista_Estudiante";
            this.Lista_Estudiante.Size = new System.Drawing.Size(207, 28);
            this.Lista_Estudiante.TabIndex = 5;
            this.Lista_Estudiante.SelectionChangeCommitted += new System.EventHandler(this.Lista_Estudiante_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Residencia :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha nacimiento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cedula :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lista Estudiantes :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Estudiantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker Fecha_Nacer;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtResidencia2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtCedula2;
        private System.Windows.Forms.DateTimePicker Fecha_Nacer2;
        private System.Windows.Forms.ComboBox Lista_Estudiante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

