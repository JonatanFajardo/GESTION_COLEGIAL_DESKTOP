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
            this.jnTexBox1 = new JNControls.Controles.JNTexBox();
            this.SuspendLayout();
            // 
            // jnTexBox1
            // 
            this.jnTexBox1.BackColor = System.Drawing.SystemColors.Window;
            this.jnTexBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jnTexBox1.BorderColorError = System.Drawing.Color.Red;
            this.jnTexBox1.BorderFocusColor = System.Drawing.Color.Silver;
            this.jnTexBox1.BorderRadius = 0;
            this.jnTexBox1.BorderSize = 1;
            this.jnTexBox1.CleanCompleted = false;
            this.jnTexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnTexBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jnTexBox1.Location = new System.Drawing.Point(206, 55);
            this.jnTexBox1.Margin = new System.Windows.Forms.Padding(4);
            this.jnTexBox1.Multiline = false;
            this.jnTexBox1.Name = "jnTexBox1";
            this.jnTexBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.jnTexBox1.PasswordChar = false;
            this.jnTexBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.jnTexBox1.PlaceholderText = "";
            this.jnTexBox1.Require = JNControls.Controles.JNTexBox.TrueFalse.False;
            this.jnTexBox1.Size = new System.Drawing.Size(250, 35);
            this.jnTexBox1.TabIndex = 0;
            this.jnTexBox1.Texts = "";
            this.jnTexBox1.TypeDate = JNControls.Controles.JNTexBox.Estados.Ninguno;
            this.jnTexBox1.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jnTexBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private JNControls.Controles.JNTexBox jnTexBox1;
    }
}

