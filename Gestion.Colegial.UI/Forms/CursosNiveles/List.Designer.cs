
namespace Gestion.Colegial.UI.Forms.CursosNiveles
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
            this.jnPanel1.SuspendLayout();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // jnPanel1
            // 
            this.jnPanel1.Size = new System.Drawing.Size(1528, 530);
            // 
            // txtBuscar
            // 
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Size = new System.Drawing.Size(282, 29);
            this.lblTituloForm.Text = "Listado Cursos Niveles";
            // 
            // pnBackground
            // 
            this.pnBackground.Size = new System.Drawing.Size(1598, 600);
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
    }
}