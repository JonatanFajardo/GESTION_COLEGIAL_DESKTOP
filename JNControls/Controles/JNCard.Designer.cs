
namespace JNControls.Controles
{
    partial class JNCard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.jnPanel1 = new JNControls.Controles.JNPanel();
            this.jnPanel2 = new JNControls.Controles.JNPanel();
            this.jnPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jnPanel1
            // 
            this.jnPanel1.BorderColor = System.Drawing.Color.White;
            this.jnPanel1.Controls.Add(this.jnPanel2);
            this.jnPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jnPanel1.Edge = 20;
            this.jnPanel1.Location = new System.Drawing.Point(15, 15);
            this.jnPanel1.Name = "jnPanel1";
            this.jnPanel1.Size = new System.Drawing.Size(498, 488);
            this.jnPanel1.TabIndex = 0;
            // 
            // jnPanel2
            // 
            this.jnPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            this.jnPanel2.BorderColor = System.Drawing.Color.White;
            this.jnPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.jnPanel2.Edge = 20;
            this.jnPanel2.Location = new System.Drawing.Point(0, 0);
            this.jnPanel2.Name = "jnPanel2";
            this.jnPanel2.Size = new System.Drawing.Size(498, 68);
            this.jnPanel2.TabIndex = 0;
            // 
            // JNCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jnPanel1);
            this.Name = "JNCard";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(528, 518);
            this.jnPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JNPanel jnPanel1;
        private JNPanel jnPanel2;
    }
}
