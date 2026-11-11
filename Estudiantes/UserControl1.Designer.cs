namespace Estudiantes
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.formulario = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.estudiante = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.estadocivil = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LblClave = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Sexo.SuspendLayout();
            this.estadocivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // formulario
            // 
            this.formulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formulario.Controls.Add(this.pictureBox1);
            this.formulario.Controls.Add(this.monthCalendar1);
            this.formulario.Controls.Add(this.dateTimePicker1);
            this.formulario.Controls.Add(this.numericUpDown1);
            this.formulario.Controls.Add(this.progressBar1);
            this.formulario.Controls.Add(this.maskedTextBox2);
            this.formulario.Controls.Add(this.comboBox1);
            this.formulario.Controls.Add(this.checkBox2);
            this.formulario.Controls.Add(this.checkBox1);
            this.formulario.Controls.Add(this.listBox1);
            this.formulario.Controls.Add(this.button4);
            this.formulario.Controls.Add(this.button3);
            this.formulario.Controls.Add(this.button2);
            this.formulario.Controls.Add(this.label5);
            this.formulario.Controls.Add(this.label4);
            this.formulario.Controls.Add(this.estudiante);
            this.formulario.Controls.Add(this.Clave);
            this.formulario.Controls.Add(this.Sexo);
            this.formulario.Controls.Add(this.estadocivil);
            this.formulario.Location = new System.Drawing.Point(42, 50);
            this.formulario.Name = "formulario";
            this.formulario.Size = new System.Drawing.Size(1115, 761);
            this.formulario.TabIndex = 0;
            this.formulario.TabStop = false;
            this.formulario.Text = "Formulario de datos";
            this.formulario.Visible = false;
            this.formulario.Enter += new System.EventHandler(this.formulario_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estudiantes.Properties.Resources.Csharp_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(532, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 484);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(24, 369);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(103, 220);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 306);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Value = 30;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(75, 41);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PasswordChar = '*';
            this.maskedTextBox2.Size = new System.Drawing.Size(159, 22);
            this.maskedTextBox2.TabIndex = 14;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sistemas",
            "Electrónica",
            "Industrial",
            "Diseño",
            "Derecho"});
            this.comboBox1.Location = new System.Drawing.Point(102, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(303, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 20);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Egresado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(102, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Sistemas",
            "Electrónica",
            "Industrial",
            "Diseño",
            "Derecho"});
            this.listBox1.Location = new System.Drawing.Point(283, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 148);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(766, 721);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Disminuir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Aumentar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Programa";
            // 
            // estudiante
            // 
            this.estudiante.AutoSize = true;
            this.estudiante.Location = new System.Drawing.Point(6, 88);
            this.estudiante.Name = "estudiante";
            this.estudiante.Size = new System.Drawing.Size(70, 16);
            this.estudiante.TabIndex = 4;
            this.estudiante.Text = "Estudiante";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(6, 41);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(42, 16);
            this.Clave.TabIndex = 3;
            this.Clave.Text = "Clave";
            this.Clave.Click += new System.EventHandler(this.Clave_Click);
            // 
            // Sexo
            // 
            this.Sexo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sexo.Controls.Add(this.radioButton4);
            this.Sexo.Controls.Add(this.radioButton3);
            this.Sexo.Location = new System.Drawing.Point(586, 138);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(404, 62);
            this.Sexo.TabIndex = 2;
            this.Sexo.TabStop = false;
            this.Sexo.Text = "Sexo";
            this.Sexo.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(238, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 20);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Femenino";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(38, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Masculino";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // estadocivil
            // 
            this.estadocivil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.estadocivil.Controls.Add(this.radioButton2);
            this.estadocivil.Controls.Add(this.radioButton1);
            this.estadocivil.Location = new System.Drawing.Point(586, 41);
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.Size = new System.Drawing.Size(404, 63);
            this.estadocivil.TabIndex = 1;
            this.estadocivil.TabStop = false;
            this.estadocivil.Text = "Estado Civil";
            this.estadocivil.Enter += new System.EventHandler(this.estadocivil_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(238, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Casado";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Soltero";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Location = new System.Drawing.Point(39, 18);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(42, 16);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave";
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Mostrar.Location = new System.Drawing.Point(297, 15);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Mostrar.TabIndex = 2;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(117, 11);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(159, 22);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.formulario);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1205, 858);
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Sexo.ResumeLayout(false);
            this.Sexo.PerformLayout();
            this.estadocivil.ResumeLayout(false);
            this.estadocivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox formulario;
        private System.Windows.Forms.GroupBox estadocivil;
        private System.Windows.Forms.GroupBox Sexo;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label estudiante;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
