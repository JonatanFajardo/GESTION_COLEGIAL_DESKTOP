
namespace Gestion.Colegial.UI.Forms.Horas
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
            this.jnPanel1.Size = new System.Drawing.Size(1528, 530);
            this.jnPanel1.Controls.SetChildIndex(this.txtBuscar, 0);
            this.jnPanel1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.jnPanel1.Controls.SetChildIndex(this.pnLoading, 0);
            // 
            // txtBuscar
            // 
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Size = new System.Drawing.Size(174, 29);
            this.lblTituloForm.Text = "Listado Horas";
            // 
            // pnBackground
            // 
            this.pnBackground.Size = new System.Drawing.Size(1598, 600);
            // 
            // pnLoading
            // 
            this.pnLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLoading.Controls.Add(this.pbLoading);
            this.pnLoading.Location = new System.Drawing.Point(561, 199);
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

        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}