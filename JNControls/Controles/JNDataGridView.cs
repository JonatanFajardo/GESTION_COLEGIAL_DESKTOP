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


            base.RowTemplate.DividerHeight = 1;
            base.RowTemplate.Resizable = DataGridViewTriState.False;

            //header
            base.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            base.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(85, 85, 170);
            base.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            base.RowTemplate.DividerHeight = 1 / 3;//tamaño de linea row;
            base.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            base.GridColor = Color.FromArgb(210, 210, 210);//tamaño de linea row;


            base.RowTemplate.Height = 35;//tamaño body



            // this.ColumnHeadersVisible = false;
            //this.RowHeadersVisible = false;
            //this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Evitando manipulacion de celdas.
            base.EnableHeadersVisualStyles = false;//permitimos que podamos editar el header
            base.ReadOnly = true;//solo lectora, no nos permite editar las columnas
            base.AllowUserToResizeColumns = false;//evitamos cambiar tamaño de columns
            base.AllowUserToResizeRows = false;//evitamos cambiar tamaño de rows
            //this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            base.MultiSelect = false;
            base.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//acomplamos el ancho de la columna al texto que ay en ella



            //no
            //this.AllowUserToResizeRows = true;
            //this.ClearSelection();

            //------- COLOR
            //this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            //row alternativa 86; 91; 100
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));

            //row cuando se seleccione
            this.DefaultCellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));

            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderStyle = BorderStyle.None;

            //Eliminando cosas esteticamente mal vistas
            //this.RowHeadersVisible = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;


        }
        public DataGridView _AddSource;
        public object AddSource
        {
            get
            {
                return this.DataSource;
            }
            set
            {
                this.DataSource = value;
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
