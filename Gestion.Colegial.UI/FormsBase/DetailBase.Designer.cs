
namespace Gestion.Colegial.UI.FormsBase
{
    partial class DetailBase
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
            this.pnBackground = new System.Windows.Forms.Panel();
            this.jnPanel1 = new JNControls.Controles.JNPanel();
            this.jnPanel2 = new JNControls.Controles.JNPanel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnBackground.SuspendLayout();
            this.jnPanel1.SuspendLayout();
            this.jnPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.AutoScroll = true;
            this.pnBackground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnBackground.Controls.Add(this.jnPanel1);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Padding = new System.Windows.Forms.Padding(35);
            this.pnBackground.Size = new System.Drawing.Size(1598, 600);
            this.pnBackground.TabIndex = 20;
            // 
            // jnPanel1
            // 
            this.jnPanel1.BackColor = System.Drawing.Color.White;
            this.jnPanel1.BorderColor = System.Drawing.Color.Maroon;
            this.jnPanel1.Controls.Add(this.jnPanel2);
            this.jnPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jnPanel1.Edge = 10;
            this.jnPanel1.Location = new System.Drawing.Point(35, 35);
            this.jnPanel1.Name = "jnPanel1";
            this.jnPanel1.Size = new System.Drawing.Size(1528, 530);
            this.jnPanel1.TabIndex = 89;
            // 
            // jnPanel2
            // 
            this.jnPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(236)))));
            this.jnPanel2.BorderColor = System.Drawing.Color.Maroon;
            this.jnPanel2.Controls.Add(this.lblTituloForm);
            this.jnPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.jnPanel2.Edge = 10;
            this.jnPanel2.Location = new System.Drawing.Point(0, 0);
            this.jnPanel2.Name = "jnPanel2";
            this.jnPanel2.Size = new System.Drawing.Size(1528, 54);
            this.jnPanel2.TabIndex = 89;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.lblTituloForm.Location = new System.Drawing.Point(28, 14);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(140, 29);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "DetailBase";
            // 
            // DetailBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 600);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailBase";
            this.Text = "DetailBase";
            this.pnBackground.ResumeLayout(false);
            this.jnPanel1.ResumeLayout(false);
            this.jnPanel2.ResumeLayout(false);
            this.jnPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnBackground;
        public JNControls.Controles.JNPanel jnPanel1;
        private JNControls.Controles.JNPanel jnPanel2;
        public System.Windows.Forms.Label lblTituloForm;
    }
}