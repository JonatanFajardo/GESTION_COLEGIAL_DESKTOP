
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.jnButton3 = new JNControls.Controles.JNButton();
            this.jnButton4 = new JNControls.Controles.JNButton();
            this.pnLoading = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.jnPanel1.SuspendLayout();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.pnLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // jnPanel1
            // 
            this.jnPanel1.Controls.Add(this.pnLoading);
            this.jnPanel1.Controls.Add(this.jnButton3);
            this.jnPanel1.Controls.Add(this.jnButton4);
            this.jnPanel1.Size = new System.Drawing.Size(1528, 530);
            this.jnPanel1.Controls.SetChildIndex(this.txtBuscar, 0);
            this.jnPanel1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.jnPanel1.Controls.SetChildIndex(this.jnButton4, 0);
            this.jnPanel1.Controls.SetChildIndex(this.jnButton3, 0);
            this.jnPanel1.Controls.SetChildIndex(this.pnLoading, 0);
            // 
            // txtBuscar
            // 
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // pnBackground
            // 
            this.pnBackground.Size = new System.Drawing.Size(1598, 600);
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
            // pnLoading
            // 
            this.pnLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLoading.Controls.Add(this.pbLoading);
            this.pnLoading.Location = new System.Drawing.Point(562, 207);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(358, 271);
            this.pnLoading.TabIndex = 98;
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(31, 3);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(298, 271);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 93;
            this.pbLoading.TabStop = false;
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
            this.pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JNControls.Controles.JNButton jnButton3;
        private JNControls.Controles.JNButton jnButton4;
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}