using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Helpers.Export;
using Gestion.Colegial.Business.Helpers.ExportCustom;
using Gestion.Colegial.Business.Messagebox;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using JNControls.Controles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Cargos
{
    public partial class List : FormBase
    {
        public List()
        {
            InitializeComponent();

            //Estilos DataGridView
            dataGridViewJN1.RowTemplate.DividerHeight = 1;
            dataGridViewJN1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewJN1.ColumnHeadersHeight = 45;
            dataGridViewJN1.RowTemplate.DividerHeight = 1 / 3;//tamaño de linea row;
            dataGridViewJN1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewFill();

            // Configuraciones DGV

            // Agregado de botones de accion.
            List<DGVHeader> actionButtons = new List<DGVHeader>()
            {
                new DGVHeader(){Name = " ", Size = 65 },
                new DGVHeader(){Name = "Accion", Size = 65 },
                new DGVHeader(){Name = "  ", Size = 65 },
            };
            dataGridViewJN1.AddBtn(actionButtons);
        }

        /// <summary>
        /// Carga los datos al datagridview con los datos especificados.
        /// </summary>
        /// <param name="buscar"></param>
        /// <param name="selected"></param>
        /// <param name="numberPagina"></param>
        public async void DataGridViewFill(string buscar = "")
        {
            // Cargamos DataGridView.
            ListResult listResult = new ListResult()
            {
                //numberPagina = numberPagina,
                //amount = selected,
                search = buscar
            };

            // Peticion de la data
            Answer data = await CargosServices.List();
            if (!data.Access)
            {
                dataGridViewJN1.Columns.Clear();
                dataGridViewJN1.DataSource = data.Data;
                AddActions();
            }
            else
                MessageBox.Show(data.Message);

            pnLoading.Visible = false;
        }

        /// <summary>
        /// Carga los datos al datagridview con los datos especificados.
        /// </summary>
        /// <param name="columna">Columna buscada.</param>
        /// <param name="search">Informacion a buscar en la columna.</param>
        public async void DataGridViewFill(string columna, string search)
        {

            // Peticion de la data
            Answer data = await CargosServices.List();
            if (!data.Access)
            {
                dataGridViewJN1.Columns.Clear();
                DataView dv = data.Data.DefaultView;
                dv.RowFilter = $"{columna} like '%{search}%'";
                dataGridViewJN1.DataSource = dv.ToTable();
                AddActions();
            }
            else
                MessageBox.Show(data.Message);

            pnLoading.Visible = false;
        }

        /// Agregado de botones de accion.
        private void AddActions()
        {
            List<DGVHeader> actionButtons = new List<DGVHeader>()
            {
                new DGVHeader(){Name = " ", Size = 65 },
                new DGVHeader(){Name = "Acciones", Size = 65 },
                new DGVHeader(){Name = "  ", Size = 65 },
            };
            dataGridViewJN1.AddBtn(actionButtons);
        }

        #region FuncionalidadesDGV
        private void jnButton1_Click(object sender, EventArgs e)
        {
            ///var obj = CargosServices.List("");
            PdfCustom.DataSource(this.Text, dataGridViewJN1);
        }

        private void jnButton2_Click(object sender, EventArgs e)
        {
            //string[] ignore = new string[] { "Editar", "Detalle", "Eliminar" };
            Excel excel = new Excel();
            ///var obj = CargosServices.List("");
            ////excel.DataSource(obj);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataGridViewFill(txtBuscar.Text);
        }
        #endregion  FuncionalidadesDGV

        #region AccionesCRUD

        /// <summary>
        /// Agrega un nuevo registro.
        /// </summary>
        public async override void Agregar()
        {
            Add add = new Add(this);
            ShowForm(add);
        }

        /// <summary>
        /// Edita o elimina registros en funcion de lo seleccionado en el DGV.
        /// </summary>
        /// <param name="e">Evento.</param>
        public async override void CellContentDGV(DataGridViewCellEventArgs e)
        {

            // Editamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[" "].Selected)
            {
                // Objeto con la data que se selecciono.
                int identifier = (Int32)dataGridViewJN1.Rows[e.RowIndex].Cells[0].Value;
                Add add = new Add(this, identifier);
                add.Show();
            }

            // Eliminamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells["  "].Selected)
            {
                Warning.ShowDialog("Desea eliminar esta fila?");
                if (Warning.isOk())
                {
                    int identifier = (Int32)dataGridViewJN1.Rows[e.RowIndex].Cells[0].Value;
                    Boolean resultService = await CargosServices.Remove(identifier);
                    DataGridViewFill();
                    if (resultService)
                    {
                        Alert.Show(Alert.enmType.Error, "No se ha podido eliminar la fila.", "Error");
                    }
                }
            }

        }



        /// <summary>
        /// This method generates a DataTable.
        /// </summary>
        //static DataTable GetTable()
        //{
        //    // Here we create a DataTable with four columns.
        //    DataTable table = new DataTable();
        //    table.Columns.Add("Dosage", typeof(int));
        //    table.Columns.Add("Drug", typeof(string));
        //    table.Columns.Add("Patient", typeof(string));
        //    table.Columns.Add("Date", typeof(DateTime));

        //    // Here we add five DataRows.
        //    table.Rows.Add(25, "Indocin", "David", DateTime.Now);
        //    table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
        //    table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
        //    table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
        //    table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
        //    return table;
        //}


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    dataGridViewJN1.DataSource = GetTable();


        //    for (int i = 0; i < dataGridViewJN1.ColumnCount; i++)
        //    {

        //    }
        //    System.Collections.Generic.List<tbCargos> lista = new System.Collections.Generic.List<tbCargos>();
        //    lista.Add(new tbCargos()
        //    {
        //        //mda_Descripcion = 
        //    });
        //    string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        //    //pictureBox1.Image = Image.FromFile(path+"/Content/image");
        //    MessageBox.Show(path);

        //}

        #endregion AccionesCRUD

        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean CamposVacios;
            CamposVacios = Validation.CamposVacios(this);
            MessageBox.Show(CamposVacios.ToString());
        }

        #endregion Eventos

    }
}
