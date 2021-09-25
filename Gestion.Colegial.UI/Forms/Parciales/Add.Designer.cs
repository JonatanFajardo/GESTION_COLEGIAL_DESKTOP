
namespace Gestion.Colegial.UI.Forms.Parciales
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
            this.label7 = new System.Windows.Forms.Label();
            this.pnBackground.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.Controls.Add(this.txtDescripcion);
            this.pnBackground.Controls.Add(this.label7);
            this.pnBackground.Size = new System.Drawing.Size(480, 260);
            this.pnBackground.Controls.SetChildIndex(this.btnAgregar, 0);
            this.pnBackground.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBackground.Controls.SetChildIndex(this.label7, 0);
            this.pnBackground.Controls.SetChildIndex(this.txtDescripcion, 0);
            // 
            // pnHeader
            // 
            this.pnHeader.Size = new System.Drawing.Size(480, 60);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Location = new System.Drawing.Point(212, 153);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(327, 153);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescripcion.BorderColorError = System.Drawing.Color.Brown;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtDescripcion.BorderRadius = 8;
            this.txtDescripcion.BorderSize = 1;
            this.txtDescripcion.CleanCompleted = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(71, 89);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.Require = JNControls.Controles.JNTexBox.TrueFalse.True;
            this.txtDescripcion.Size = new System.Drawing.Size(365, 35);
            this.txtDescripcion.TabIndex = 14;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.TypeDate = JNControls.Controles.JNTexBox.Estados.Ninguno;
            this.txtDescripcion.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(68, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modalidad";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Name = "Add";
            this.Text = "Add";
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private JNControls.Controles.JNTexBox txtDescripcion;
        private System.Windows.Forms.Label label7;
    }
}