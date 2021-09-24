using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JNControls.Controles
{
    public partial class JNDataGridView : DataGridView
    {
        public JNDataGridView()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            // this.ColumnHeadersVisible = false;
            //this.RowHeadersVisible = false;
            this.EnableHeadersVisualStyles = false;//permitimos que podamos editar el header
            //this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ReadOnly = true;//solo lectora, no nos permite editar las columnas
            this.AllowUserToResizeColumns = false;//evitamos cambiar tamaño de columns
            this.AllowUserToResizeRows = false;//evitamos cambiar tamaño de rows
            //this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//acomplamos el ancho de la columna al texto que ay en ella
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ColumnHeadersHeight = 45;


            //no
            this.AllowUserToResizeRows = true;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ClearSelection();

            //------- COLOR
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            //row alternativa 86; 91; 100
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));

            //row cuando se seleccione
            this.DefaultCellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));

            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderStyle = BorderStyle.None;

            //Eliminando cosas esteticamente mal vistas
            this.RowHeadersVisible = false;
        }


        /// <summary>
        /// Establece botones con imagenes
        /// </summary>
        ///// <param name="position">Indicara el lado al que se orientaran los botones.</param>
        ///// <param name="name">Nombre que tendra la columna.</param>
        ///// <param name="image">Direccion de la imagen.</param>
        public void AddBtn(List<DGVHeader> actionButtons)
        {//PositionDgv position, string[] name, string[] image, int[] size
            string[] img = new string[] { "image\\dgv\\Edit.png", "image\\dgv\\Details.png", "image\\dgv\\Delete.png" };
            DataGridViewImageColumn[] btn = new DataGridViewImageColumn[Name.Length];
            for (int i = 0; i < actionButtons.Count; i++)
            {
                //if (posicion == PositionDgv.start)
                //{
                //    int count = dataGridViewJN1.RowCount;
                //        dataGridViewJN1.Columns[i].DisplayIndex = 1;
                //}
                btn[i] = new DataGridViewImageColumn();
                this.Columns.Add(btn[i]);
                btn[i].Name = $"{actionButtons[i].Name}";
                Image image1 = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\GESTION_COLEGIAL_DESKTOP\\Gestion.Colegial.UI\\Content\\" + img[i]);
                btn[i].Resizable = DataGridViewTriState.True;
                btn[i].Image = image1;
                this.Columns[actionButtons[i].Name].Width = actionButtons[i].Size;

            }

        }


        /// <summary>
        /// Establese valores al header del DataGridView.
        /// 
        /// Info:Dejar vacio el name si no se desea visualizar la columna.
        /// </summary>
        /// <param name="listHeader"></param>
        public void SetHeaderText(List<DGVHeader> listHeader)
        {
            for (int i = 0; i < listHeader.Count; i++)
            {
                try
                {
                    //evitamos que este sea diferente de vacio por si este no trae valores.
                    if (listHeader[i].Name.Trim() != "")
                    {
                        this.Columns[i].HeaderText = listHeader[i].Name;
                        //evitamos que este sea diferente de cero por si este no trae valores.
                        if (listHeader[i].Size != 0)
                        {
                            this.Columns[i].Width = listHeader[i].Size;
                        }
                    }
                    else
                    {
                        this.Columns[i].Visible = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Los datos especificados en el header no coinciden con los obtenidos desde la Base de Datos.");
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
    public class DGVHeader
    {
        //public PositionDgv Position { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        //public enum PositionDgv
        //{
        //    custom,
        //    start,
        //    end
        //}
    }
}
