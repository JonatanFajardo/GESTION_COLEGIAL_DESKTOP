
namespace Gestion.Colegial.UI.Forms.Alumnos
{
    partial class List
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
            this.jnButton3 = new JNControls.Controles.JNButton();
            this.jnButton4 = new JNControls.Controles.JNButton();
            this.jnPanel1.SuspendLayout();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // jnPanel1
            // 
            this.jnPanel1.Controls.Add(this.jnButton3);
            this.jnPanel1.Controls.Add(this.jnButton4);
            this.jnPanel1.Size = new System.Drawing.Size(1528, 530);
            this.jnPanel1.Controls.SetChildIndex(this.txtBuscar, 0);
            this.jnPanel1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.jnPanel1.Controls.SetChildIndex(this.jnButton4, 0);
            this.jnPanel1.Controls.SetChildIndex(this.jnButton3, 0);
            // 
            // pnBackground
            // 
            this.pnBackground.Size = new System.Drawing.Size(1598, 600);
            //this.pnBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBackground_Paint);
            // 
            // jnButton3
            // 
            this.jnButton3.BackColor = System.Drawing.Color.Silver;
            this.jnButton3.BackgroundColor = System.Drawing.Color.Silver;
            this.jnButton3.BorderColor = System.Drawing.Color.White;
            this.jnButton3.BorderRadius = 10;
            this.jnButton3.BorderSize = 0;
            this.jnButton3.FlatAppearance.BorderSize = 0;
            this.jnButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jnButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnButton3.ForeColor = System.Drawing.Color.White;
            this.jnButton3.Location = new System.Drawing.Point(676, 75);
            this.jnButton3.Name = "jnButton3";
            this.jnButton3.Size = new System.Drawing.Size(72, 42);
            this.jnButton3.TabIndex = 91;
            this.jnButton3.Text = "Excel";
            this.jnButton3.TextColor = System.Drawing.Color.White;
            this.jnButton3.UseVisualStyleBackColor = false;
            // 
            // jnButton4
            // 
            this.jnButton4.BackColor = System.Drawing.Color.Silver;
            this.jnButton4.BackgroundColor = System.Drawing.Color.Silver;
            this.jnButton4.BorderColor = System.Drawing.Color.White;
            this.jnButton4.BorderRadius = 10;
            this.jnButton4.BorderSize = 0;
            this.jnButton4.FlatAppearance.BorderSize = 0;
            this.jnButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jnButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnButton4.ForeColor = System.Drawing.Color.White;
            this.jnButton4.Location = new System.Drawing.Point(598, 75);
            this.jnButton4.Name = "jnButton4";
            this.jnButton4.Size = new System.Drawing.Size(72, 42);
            this.jnButton4.TabIndex = 90;
            this.jnButton4.Text = "PDF";
            this.jnButton4.TextColor = System.Drawing.Color.White;
            this.jnButton4.UseVisualStyleBackColor = false;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 600);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "List";
            this.Text = "List";
            this.jnPanel1.ResumeLayout(false);
            this.jnPanel1.PerformLayout();
            this.pnBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JNControls.Controles.JNButton jnButton3;
        private JNControls.Controles.JNButton jnButton4;
    }
}