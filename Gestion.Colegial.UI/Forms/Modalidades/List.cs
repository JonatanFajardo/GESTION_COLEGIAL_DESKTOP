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
using System.Drawing;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Modalidades
{
    public partial class List : FormBase
    {
        /// <summary>
        /// Color primario de los botones
        /// </summary>
        private Color BackColorPaginateButton = Color.FromArgb(85, 85, 170);

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
            Answer data = await ModalidadesServices.List();
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
            Answer data = await ModalidadesServices.List();
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
            ///var obj = ModalidadesServices.List("");
            PdfCustom.DataSource(this.Text, dataGridViewJN1);
        }

        private void jnButton2_Click(object sender, EventArgs e)
        {
            //string[] ignore = new string[] { "Editar", "Detalle", "Eliminar" };
            Excel excel = new Excel();
            ///var obj = ModalidadesServices.List("");
            ////excel.DataSource(obj);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataGridViewFill("Descripción", txtBuscar.Text);
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
                tbModalidades objModalidades = new tbModalidades()
                {
                    Mda_Id = Convert.ToInt32(dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value),
                    Mda_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString()
                };
                int id = (int)dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value;
                Add add = new Add(this, id);
                add.Show();
            }

            // Eliminamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells["  "].Selected)
            {
                Warning.ShowDialog("Desea eliminar esta fila?");
                if (Warning.isOk())
                {
                    tbModalidades objModalidades = new tbModalidades()
                    {
                        Mda_Id = (int)dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value,
                        //Mda_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString()
                    };
                    Boolean resultService = await ModalidadesServices.Remove(objModalidades.Mda_Id);
                    DataGridViewFill();
                    if (resultService)
                    {
                        Alert.Show(Alert.enmType.Error, "No se ha podido eliminar la fila.", "Error");
                    }
                }
            }

        }

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

    //public class DataGridHeaderText
    //{
    //    public string HeaderText { get; set; }
    //    public bool Visible { get; set; }
    //}

}
