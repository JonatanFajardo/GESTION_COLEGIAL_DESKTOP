

namespace Gestion.Colegial.UI.Forms.Eventos
{
    partial class Add
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
            this.label7 = new System.Windows.Forms.Label();
            this.even_Nombre = new JNControls.Controles.JNTexBox();
            this.even_Informacion = new JNControls.Controles.JNTexBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jnTexBox2 = new JNControls.Controles.JNTexBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jnTexBox3 = new JNControls.Controles.JNTexBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbConcluido = new System.Windows.Forms.CheckBox();
            this.even_Fecha = new System.Windows.Forms.DateTimePicker();
            this.even_Hora = new System.Windows.Forms.DateTimePicker();
            this.pnBackground.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.Controls.Add(this.even_Hora);
            this.pnBackground.Controls.Add(this.even_Fecha);
            this.pnBackground.Controls.Add(this.ckbConcluido);
            this.pnBackground.Controls.Add(this.jnTexBox3);
            this.pnBackground.Controls.Add(this.label4);
            this.pnBackground.Controls.Add(this.jnTexBox2);
            this.pnBackground.Controls.Add(this.label3);
            this.pnBackground.Controls.Add(this.even_Informacion);
            this.pnBackground.Controls.Add(this.label2);
            this.pnBackground.Controls.Add(this.even_Nombre);
            this.pnBackground.Controls.Add(this.label7);
            this.pnBackground.Size = new System.Drawing.Size(754, 360);
            this.pnBackground.Controls.SetChildIndex(this.label7, 0);
            this.pnBackground.Controls.SetChildIndex(this.even_Nombre, 0);
            this.pnBackground.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBackground.Controls.SetChildIndex(this.btnAgregar, 0);
            this.pnBackground.Controls.SetChildIndex(this.label2, 0);
            this.pnBackground.Controls.SetChildIndex(this.even_Informacion, 0);
            this.pnBackground.Controls.SetChildIndex(this.label3, 0);
            this.pnBackground.Controls.SetChildIndex(this.jnTexBox2, 0);
            this.pnBackground.Controls.SetChildIndex(this.label4, 0);
            this.pnBackground.Controls.SetChildIndex(this.jnTexBox3, 0);
            this.pnBackground.Controls.SetChildIndex(this.ckbConcluido, 0);
            this.pnBackground.Controls.SetChildIndex(this.even_Fecha, 0);
            this.pnBackground.Controls.SetChildIndex(this.even_Hora, 0);
            // 
            // pnHeader
            // 
            this.pnHeader.Size = new System.Drawing.Size(754, 60);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Location = new System.Drawing.Point(482, 282);
            this.btnAgregar.Size = new System.Drawing.Size(112, 42);
            this.btnAgregar.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(600, 282);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(985, 16);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(55, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            // 
            // even_Nombre
            // 
            this.even_Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.even_Nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.even_Nombre.BorderColorError = System.Drawing.Color.Brown;
            this.even_Nombre.BorderFocusColor = System.Drawing.Color.Silver;
            this.even_Nombre.BorderRadius = 8;
            this.even_Nombre.BorderSize = 1;
            this.even_Nombre.CleanCompleted = true;
            this.even_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.even_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.even_Nombre.Location = new System.Drawing.Point(58, 89);
            this.even_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.even_Nombre.Multiline = false;
            this.even_Nombre.Name = "even_Nombre";
            this.even_Nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.even_Nombre.PasswordChar = false;
            this.even_Nombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.even_Nombre.PlaceholderText = "";
            this.even_Nombre.Require = JNControls.Controles.JNTexBox.TrueFalse.True;
            this.even_Nombre.Size = new System.Drawing.Size(302, 35);
            this.even_Nombre.TabIndex = 0;
            this.even_Nombre.Texts = "";
            this.even_Nombre.TypeDate = JNControls.Controles.JNTexBox.Estados.Ninguno;
            this.even_Nombre.UnderlinedStyle = false;
            // 
            // even_Informacion
            // 
            this.even_Informacion.BackColor = System.Drawing.SystemColors.Window;
            this.even_Informacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.even_Informacion.BorderColorError = System.Drawing.Color.Brown;
            this.even_Informacion.BorderFocusColor = System.Drawing.Color.Silver;
            this.even_Informacion.BorderRadius = 8;
            this.even_Informacion.BorderSize = 1;
            this.even_Informacion.CleanCompleted = true;
            this.even_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.even_Informacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.even_Informacion.Location = new System.Drawing.Point(58, 203);
            this.even_Informacion.Margin = new System.Windows.Forms.Padding(4);
            this.even_Informacion.Multiline = true;
            this.even_Informacion.Name = "even_Informacion";
            this.even_Informacion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.even_Informacion.PasswordChar = false;
            this.even_Informacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.even_Informacion.PlaceholderText = "";
            this.even_Informacion.Require = JNControls.Controles.JNTexBox.TrueFalse.True;
            this.even_Informacion.Size = new System.Drawing.Size(302, 121);
            this.even_Informacion.TabIndex = 3;
            this.even_Informacion.Texts = "";
            this.even_Informacion.TypeDate = JNControls.Controles.JNTexBox.Estados.Ninguno;
            this.even_Informacion.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(55, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Información";
            // 
            // jnTexBox2
            // 
            this.jnTexBox2.BackColor = System.Drawing.SystemColors.Window;
            this.jnTexBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jnTexBox2.BorderColorError = System.Drawing.Color.Brown;
            this.jnTexBox2.BorderFocusColor = System.Drawing.Color.Silver;
            this.jnTexBox2.BorderRadius = 8;
            this.jnTexBox2.BorderSize = 1;
            this.jnTexBox2.CleanCompleted = true;
            this.jnTexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnTexBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jnTexBox2.Location = new System.Drawing.Point(399, 89);
            this.jnTexBox2.Margin = new System.Windows.Forms.Padding(4);
            this.jnTexBox2.Multiline = false;
            this.jnTexBox2.Name = "jnTexBox2";
            this.jnTexBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.jnTexBox2.PasswordChar = false;
            this.jnTexBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.jnTexBox2.PlaceholderText = "";
            this.jnTexBox2.Require = JNControls.Controles.JNTexBox.TrueFalse.True;
            this.jnTexBox2.Size = new System.Drawing.Size(302, 35);
            this.jnTexBox2.TabIndex = 5;
            this.jnTexBox2.Texts = "";
            this.jnTexBox2.TypeDate = JNControls.Controles.JNTexBox.Estados.Ninguno;
            this.jnTexBox2.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(395, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // jnTexBox3
            // 
            this.jnTexBox3.BackColor = System.Drawing.SystemColors.Window;
            this.jnTexBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jnTexBox3.BorderColorError = System.Drawing.Color.Brown;
            this.jnTexBox3.BorderFocusColor = System.Drawing.Color.Silver;
            this.jnTexBox3.BorderRadius = 8;
            this.jnTexBox3.BorderSize = 1;
            this.jnTexBox3.CleanCompleted = true;
            this.jnTexBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnTexBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jnTexBox3.Location = new System.Drawing.Point(408, 203);
            this.jnTexBox3.Margin = new System.Windows.Forms.Padding(4);
            this.jnTexBox3.Multiline = false;
            this.jnTexBox3.Name = "jnTexBox3";
            this.jnTexBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.jnTexBox3.PasswordChar = false;
            this.jnTexBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.jnTexBox3.PlaceholderText = "";
            this.jnTexBox3.Require = JNControls.Controles.JNTexBox.TrueFalse.True;
            this.jnTexBox3.Size = new System.Drawing.Size(302, 35);
            this.jnTexBox3.TabIndex = 7;
            this.jnTexBox3.Texts = "";
            this.jnTexBox3.TypeDate = JNControls.Controles.JNTexBox.Estados.Ninguno;
            this.jnTexBox3.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(405, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora";
            // 
            // ckbConcluido
            // 
            this.ckbConcluido.AutoSize = true;
            this.ckbConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ckbConcluido.ForeColor = System.Drawing.Color.Black;
            this.ckbConcluido.Location = new System.Drawing.Point(597, 245);
            this.ckbConcluido.Name = "ckbConcluido";
            this.ckbConcluido.Size = new System.Drawing.Size(112, 26);
            this.ckbConcluido.TabIndex = 9;
            this.ckbConcluido.Text = "Concluido";
            this.ckbConcluido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbConcluido.UseVisualStyleBackColor = true;
            // 
            // even_Fecha
            // 
            this.even_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.even_Fecha.Location = new System.Drawing.Point(408, 97);
            this.even_Fecha.Name = "even_Fecha";
            this.even_Fecha.Size = new System.Drawing.Size(280, 22);
            this.even_Fecha.TabIndex = 10;
            // 
            // even_Hora
            // 
            this.even_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.even_Hora.Location = new System.Drawing.Point(419, 210);
            this.even_Hora.Name = "even_Hora";
            this.even_Hora.Size = new System.Drawing.Size(276, 22);
            this.even_Hora.TabIndex = 11;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 420);
            this.Name = "Add";
            this.Text = "Add";
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JNControls.Controles.JNTexBox even_Nombre;
        private System.Windows.Forms.Label label7;
        private JNControls.Controles.JNTexBox jnTexBox3;
        private System.Windows.Forms.Label label4;
        private JNControls.Controles.JNTexBox jnTexBox2;
        private System.Windows.Forms.Label label3;
        private JNControls.Controles.JNTexBox even_Informacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbConcluido;
        private System.Windows.Forms.DateTimePicker even_Hora;
        private System.Windows.Forms.DateTimePicker even_Fecha;
    }
}
