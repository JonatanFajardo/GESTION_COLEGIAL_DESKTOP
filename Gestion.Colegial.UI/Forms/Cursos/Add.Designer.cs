
using JNControls.Controles;

namespace Gestion.Colegial.UI.Forms.Cursos
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
            this.txtDescripcion = new JNControls.Controles.JNTexBox();
            this.pnBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.Controls.Add(this.txtDescripcion);
            this.pnBackground.Size = new System.Drawing.Size(1268, 485);

            this.pnBackground.Controls.SetChildIndex(this.txtDescripcion, 0);
            // 
            // pnHeader
            // 
            this.pnHeader.Size = new System.Drawing.Size(1268, 83);
      
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescripcion.BorderColorError = System.Drawing.Color.Brown;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtDescripcion.BorderRadius = 8;
            this.txtDescripcion.BorderSize = 1;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(57, 80);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.Require = JNTexBox.TrueFalse.True;
            this.txtDescripcion.Size = new System.Drawing.Size(365, 35);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.TypeDate = JNTexBox.Estados.Ninguno;
            this.txtDescripcion.UnderlinedStyle = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 568);
            this.Name = "Add";
            this.Text = "Add";
            this.pnBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JNControls.Controles.JNTexBox txtDescripcion;
    }
}