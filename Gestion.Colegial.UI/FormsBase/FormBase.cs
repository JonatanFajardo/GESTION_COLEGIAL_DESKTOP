using Gestion.Colegial.Commons.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.FormsBase
{
    public partial class FormBase : Form
    {

        /*===============================================
                Constructor e inicializacion
        ================================================*/
        public FormBase()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            //dgvWidth(dataGridViewJN1);

            // Cargamos con data el combobox de length.

        }

        /*===============================================
                          FUNCIONES
        ================================================*/


        /// <summary>
        /// Aplica estilo al DataGridView indicado.
        /// </summary>
        /// <param name="dataGrid"></param>
        void dgvConfig(DataGridView dataGrid)
        {
            // dataGrid.ColumnHeadersVisible = false;
            //dataGrid.RowHeadersVisible = false;
            //dataGrid.EnableHeadersVisualStyles = false;//permitimos que podamos editar el header
            //dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ReadOnly = true;//solo lectora, no nos permite editar las columnas
            //dataGrid.AllowUserToResizeColumns = false;//evitamos cambiar tamaño de columns
            //dataGrid.AllowUserToResizeRows = false;//evitamos cambiar tamaño de rows
            //dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGrid.MultiSelect = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//acomplamos el ancho de la columna al texto que ay en ella

            //no
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ClearSelection();

            //------- COLOR
            dataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGrid.ForeColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            //row alternativa
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));

            //row cuando se seleccione
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));

            dataGrid.BackgroundColor = System.Drawing.Color.White;
            //dataGrid.BorderStyle = BorderStyle.None;
            //dgvWidth(dataGrid);
        }

        ////== ESTABLECE TAMAÑOS A LAS PRIMERAS 2 COLUMNAS
        //void dgvWidth(DataGridView dataGrid)
        //{
        //    //////dataGrid.Columns[0].Width = 40;
        //    //////dataGrid.Columns[1].Width = 40;
        //    //dataGrid.Columns[1].AutoSizeMode= DataGridViewAutoSizeColumnMode.DisplayedCells;
        //}

        public void nameForm(string text)
        {
            //lblForm.Text = text;
            //form.Text = lblForm.Text;
        }

        public virtual void Agregar()
        {

        }

        public virtual void buscar()
        {

        }


        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }


        public virtual void CellContentDGV(DataGridViewCellEventArgs e)
        {
            //virtual   
        }


        //public virtual void Titulo()
        //{
        //    lblTituloForm.Text = ;
        //}



        /// <summary>
        /// Carga los datos de el tamaño por pagina en el combobox.
        /// </summary>
        /// <param name="dataGridViewLength"></param>
        public void DataGridViewLengthLoad(ComboBox dataGridViewLength = null)
        {
            //cbAmount.Items.Clear();
            //El dgv puede ser nulo cuando =================---===
            if (dataGridViewLength != null)
            {
                List<ComboboxValue> comboboxValues = new List<ComboboxValue>()
                {
                    new ComboboxValue() { Index = 10, Value = 10 },
                    new ComboboxValue() { Index = 25, Value = 25 },
                    new ComboboxValue() { Index = 50, Value = 50 },
                    new ComboboxValue() { Index = 100, Value = 100 }
                };
                dataGridViewLength.DataSource = comboboxValues;
                dataGridViewLength.ValueMember = "Index";
                dataGridViewLength.DisplayMember = "Value";
            }
        }




        protected void ShowForm(Form form)
        {
            //Se busca el forms indicado entre los abiertos.
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form);

            //if (frm != null)
            //{
            //    //Si la instancia existe se muestra en primer plano.
            //    frm.BringToFront();
            //    return;
            //}
            ////Sino existe la instancia se crea una nueva.

            //frm = new form();
            //frm.Show();

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                string nombreForm = Application.OpenForms[i].ToString();

                if (nombreForm.Contains(form.Text) != false)
                {
                    //Si la instancia existe se muestra en primer plano.
                    form.BringToFront();
                    return;
                }
            }
            form.ShowDialog();
            return;

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void dataGridViewJN1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CellContentDGV(e);
        }






        //void DataGridViewLengthLoad(ComboBox dataGridViewLength = null)
        //{
        //    //cbAmount.Items.Clear();
        //    if (dataGridViewLength != null)
        //    {
        //        List<ComboboxValue> comboboxValues = new List<ComboboxValue>()
        //        {
        //            new ComboboxValue() { Index = 10, Value = 10 },
        //            new ComboboxValue() { Index = 25, Value = 25 },
        //            new ComboboxValue() { Index = 50, Value = 50 },
        //            new ComboboxValue() { Index = 100, Value = 100 }
        //        };
        //        dataGridViewLength.DataSource = comboboxValues;
        //        dataGridViewLength.ValueMember = "Index";
        //        dataGridViewLength.DisplayMember = "Value";
        //    }
        //}



        //private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex > -1)
        //    {
        //        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
        //    }
        //}
    }
}
