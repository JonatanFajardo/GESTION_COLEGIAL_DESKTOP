
using JNControls.Controles;

namespace Gestion.Colegial.UI.Forms.Modalidades
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescripcion = new JNControls.Controles.JNTexBox();
            this.jnButton1 = new JNControls.Controles.JNButton();
            this.jnButton2 = new JNControls.Controles.JNButton();
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
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Size = new System.Drawing.Size(256, 29);
            this.lblTituloForm.Text = "Listado Modalidades";
            // 
            // pnBackground
            // 
            this.pnBackground.Size = new System.Drawing.Size(1598, 600);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescripcion.BorderColorError = System.Drawing.Color.Brown;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtDescripcion.BorderRadius = 8;
            this.txtDescripcion.BorderSize = 1;
            this.txtDescripcion.CleanCompleted = false;
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
            this.txtDescripcion.Require = JNControls.Controles.JNTexBox.TrueFalse.True;
            this.txtDescripcion.Size = new System.Drawing.Size(365, 35);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.TypeDate = JNControls.Controles.JNTexBox.Estados.Ninguno;
            this.txtDescripcion.UnderlinedStyle = false;
            // 
            // jnButton1
            // 
            this.jnButton1.BackColor = System.Drawing.Color.Silver;
            this.jnButton1.BackgroundColor = System.Drawing.Color.Silver;
            this.jnButton1.BorderColor = System.Drawing.Color.White;
            this.jnButton1.BorderRadius = 10;
            this.jnButton1.BorderSize = 0;
            this.jnButton1.FlatAppearance.BorderSize = 0;
            this.jnButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jnButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnButton1.ForeColor = System.Drawing.Color.White;
            this.jnButton1.Location = new System.Drawing.Point(937, 34);
            this.jnButton1.Name = "jnButton1";
            this.jnButton1.Size = new System.Drawing.Size(72, 42);
            this.jnButton1.TabIndex = 84;
            this.jnButton1.Text = "PDF";
            this.jnButton1.TextColor = System.Drawing.Color.White;
            this.jnButton1.UseVisualStyleBackColor = false;
            this.jnButton1.Click += new System.EventHandler(this.jnButton1_Click);
            // 
            // jnButton2
            // 
            this.jnButton2.BackColor = System.Drawing.Color.Silver;
            this.jnButton2.BackgroundColor = System.Drawing.Color.Silver;
            this.jnButton2.BorderColor = System.Drawing.Color.White;
            this.jnButton2.BorderRadius = 10;
            this.jnButton2.BorderSize = 0;
            this.jnButton2.FlatAppearance.BorderSize = 0;
            this.jnButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jnButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnButton2.ForeColor = System.Drawing.Color.White;
            this.jnButton2.Location = new System.Drawing.Point(1015, 34);
            this.jnButton2.Name = "jnButton2";
            this.jnButton2.Size = new System.Drawing.Size(72, 42);
            this.jnButton2.TabIndex = 85;
            this.jnButton2.Text = "Excel";
            this.jnButton2.TextColor = System.Drawing.Color.White;
            this.jnButton2.UseVisualStyleBackColor = false;
            this.jnButton2.Click += new System.EventHandler(this.jnButton2_Click);
            // 
            // pnLoading
            // 
            this.pnLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLoading.Controls.Add(this.pbLoading);
            this.pnLoading.Location = new System.Drawing.Point(584, 201);
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
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "List";
            this.Text = "Modalidades";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.pnBackground, 0);
            this.jnPanel1.ResumeLayout(false);
            this.jnPanel1.PerformLayout();
            this.pnBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private JNControls.Controles.JNTexBox txtDescripcion;
        private JNControls.Controles.JNButton jnButton1;
        private JNControls.Controles.JNButton jnButton2;
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}