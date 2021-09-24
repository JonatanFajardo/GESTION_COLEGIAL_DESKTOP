using JNControls.Controles;

namespace Gestion.Colegial.UI.Forms.Alumnos
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
            this.jnTexbox1 = new JNControls.Controles.JNTexBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.Controls.Add(this.label7);
            this.pnBackground.Controls.Add(this.jnTexbox1);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.None;
            this.pnBackground.Location = new System.Drawing.Point(108, 197);
            this.pnBackground.Size = new System.Drawing.Size(480, 249);
            this.pnBackground.Controls.SetChildIndex(this.btnAgregar, 0);
            this.pnBackground.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnBackground.Controls.SetChildIndex(this.jnTexbox1, 0);
            this.pnBackground.Controls.SetChildIndex(this.label7, 0);
            // 
            // pnHeader
            // 
            this.pnHeader.Size = new System.Drawing.Size(1169, 61);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Location = new System.Drawing.Point(198, 147);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(313, 147);
            // 
            // jnTexbox1
            // 
            this.jnTexbox1.BackColor = System.Drawing.SystemColors.Window;
            this.jnTexbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jnTexbox1.BorderColorError = System.Drawing.Color.Brown;
            this.jnTexbox1.BorderFocusColor = System.Drawing.Color.Silver;
            this.jnTexbox1.BorderRadius = 8;
            this.jnTexbox1.BorderSize = 1;
            this.jnTexbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnTexbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jnTexbox1.Location = new System.Drawing.Point(13, 54);
            this.jnTexbox1.Margin = new System.Windows.Forms.Padding(4);
            this.jnTexbox1.Multiline = false;
            this.jnTexbox1.Name = "jnTexbox1";
            this.jnTexbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.jnTexbox1.PasswordChar = false;
            this.jnTexbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.jnTexbox1.PlaceholderText = "";
            this.jnTexbox1.Require = JNTexBox.TrueFalse.True;
            this.jnTexbox1.Size = new System.Drawing.Size(365, 35);
            this.jnTexbox1.TabIndex = 7;
            this.jnTexbox1.Texts = "";
            this.jnTexbox1.TypeDate = JNTexBox.Estados.Ninguno;
            this.jnTexbox1.UnderlinedStyle = false;



            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label7.Location = new System.Drawing.Point(53, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 350;
            this.label7.Text = "Descripcion";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 640);
            this.Name = "Add";
            this.Text = "Add";
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private JNControls.Controles.JNTexBox jnTexbox1;
        private System.Windows.Forms.Label label7;
    }
}