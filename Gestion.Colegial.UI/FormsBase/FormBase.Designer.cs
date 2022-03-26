
namespace Gestion.Colegial.UI.FormsBase
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jnPanel1 = new JNControls.Controles.JNPanel();
            this.btnAgregar = new JNControls.Controles.JNButton();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.dataGridViewJN1 = new JNControls.Controles.JNDataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BgSearch = new System.Windows.Forms.PictureBox();
            this.jnPanel2 = new JNControls.Controles.JNPanel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.jnPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgSearch)).BeginInit();
            this.jnPanel2.SuspendLayout();
            this.pnBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // jnPanel1
            // 
            this.jnPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jnPanel1.BackColor = System.Drawing.Color.White;
            this.jnPanel1.BorderColor = System.Drawing.Color.Maroon;
            this.jnPanel1.Controls.Add(this.btnAgregar);
            this.jnPanel1.Controls.Add(this.btnBuscar);
            this.jnPanel1.Controls.Add(this.dataGridViewJN1);
            this.jnPanel1.Controls.Add(this.txtBuscar);
            this.jnPanel1.Controls.Add(this.BgSearch);
            this.jnPanel1.Controls.Add(this.jnPanel2);
            this.jnPanel1.Edge = 10;
            this.jnPanel1.Location = new System.Drawing.Point(35, 35);
            this.jnPanel1.Name = "jnPanel1";
            this.jnPanel1.Size = new System.Drawing.Size(1530, 530);
            this.jnPanel1.TabIndex = 89;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(1391, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 42);
            this.btnAgregar.TabIndex = 92;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(27, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 37);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.TabStop = false;
            // 
            // dataGridViewJN1
            // 
            this.dataGridViewJN1.AllowUserToAddRows = false;
            this.dataGridViewJN1.AllowUserToDeleteRows = false;
            this.dataGridViewJN1.AllowUserToResizeColumns = false;
            this.dataGridViewJN1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewJN1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJN1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJN1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewJN1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewJN1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewJN1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewJN1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJN1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewJN1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJN1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewJN1.EnableHeadersVisualStyles = false;
            this.dataGridViewJN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewJN1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dataGridViewJN1.Location = new System.Drawing.Point(22, 145);
            this.dataGridViewJN1.MultiSelect = false;
            this.dataGridViewJN1.Name = "dataGridViewJN1";
            this.dataGridViewJN1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJN1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewJN1.RowHeadersVisible = false;
            this.dataGridViewJN1.RowHeadersWidth = 51;
            this.dataGridViewJN1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewJN1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJN1.Size = new System.Drawing.Size(1488, 357);
            this.dataGridViewJN1.TabIndex = 90;
            this.dataGridViewJN1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJN1_CellClick_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(79, 86);
            this.txtBuscar.MaxLength = 27;
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(268, 22);
            this.txtBuscar.TabIndex = 79;
            // 
            // BgSearch
            // 
            this.BgSearch.BackColor = System.Drawing.Color.White;
            this.BgSearch.Image = ((System.Drawing.Image)(resources.GetObject("BgSearch.Image")));
            this.BgSearch.Location = new System.Drawing.Point(12, 73);
            this.BgSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BgSearch.Name = "BgSearch";
            this.BgSearch.Size = new System.Drawing.Size(486, 47);
            this.BgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BgSearch.TabIndex = 78;
            this.BgSearch.TabStop = false;
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
            this.jnPanel2.Size = new System.Drawing.Size(1530, 54);
            this.jnPanel2.TabIndex = 89;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.lblTituloForm.Location = new System.Drawing.Point(28, 14);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(133, 29);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "FormBase";
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
            this.pnBackground.Size = new System.Drawing.Size(1600, 600);
            this.pnBackground.TabIndex = 19;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 600);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1598, 600);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.jnPanel1.ResumeLayout(false);
            this.jnPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgSearch)).EndInit();
            this.jnPanel2.ResumeLayout(false);
            this.jnPanel2.PerformLayout();
            this.pnBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public JNControls.Controles.JNPanel jnPanel1;
        private JNControls.Controles.JNButton btnAgregar;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox BgSearch;
        private JNControls.Controles.JNPanel jnPanel2;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnBackground;
        public System.Windows.Forms.PictureBox btnBuscar;
        protected JNControls.Controles.JNDataGridView dataGridViewJN1;
    }
}