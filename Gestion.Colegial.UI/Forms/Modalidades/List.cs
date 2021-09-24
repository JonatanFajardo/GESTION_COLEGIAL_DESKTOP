using Gestion.Colegial.Business.Helpers.Export;
using Gestion.Colegial.Business.Helpers.ExportCustom;
using Gestion.Colegial.Business.Helpers;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using JNControls.Controles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Gestion.Colegial.Business.Messagebox;
using Gestion.Colegial.Business.Helpers.Alert;

namespace Gestion.Colegial.UI.Forms.Modalidades
{
    public partial class List : FormBase
    {

        private string _pathclass;
        public string pathClass { get => _pathclass; set => _pathclass = value; }



        /// <summary>
        /// Color primario de los botones
        /// </summary>
        private Color BackColorPaginateButton = Color.FromArgb(85, 85, 170);

        public List()
        {
            InitializeComponent();


            dataGridViewJN1.RowTemplate.DividerHeight = 1;
            dataGridViewJN1.RowTemplate.Resizable = DataGridViewTriState.False;

            //header
            dataGridViewJN1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewJN1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewJN1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(85, 85, 170);
            dataGridViewJN1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewJN1.ColumnHeadersHeight = 45;



            dataGridViewJN1.RowTemplate.DividerHeight = 1 / 3;//tamaño de linea row;
            dataGridViewJN1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewJN1.GridColor = Color.FromArgb(210, 210, 210);//tamaño de linea row;


            dataGridViewJN1.RowTemplate.Height = 35;//tamaño body

            dataGridViewJN1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewFill();

            List<DGVHeader> actionButtons = new List<DGVHeader>()
            {
                new DGVHeader(){Name = " ", Size = 65 },
                new DGVHeader(){Name = "Acciones", Size = 65 },
                new DGVHeader(){Name = "  ", Size = 65 },
            };
            dataGridViewJN1.AddBtn(actionButtons);

            // Se cambia el nombres del header.
            List<DGVHeader> listHeader = new List<DGVHeader>()
            {
                new DGVHeader(){Name = "Linea"},
                new DGVHeader(){Name = "Descripción"}
            };
            dataGridViewJN1.SetHeaderText(listHeader);

        }

        /// <summary>
        /// Carga los datos al datagridview con los datos especificados.
        /// </summary>
        /// <param name="buscar"></param>
        /// <param name="selected"></param>
        /// <param name="numberPagina"></param>
        public void DataGridViewFill(string buscar = "")
        {
            // Cargamos DataGridView.
            ListResult listResult = new ListResult()
            {
                //numberPagina = numberPagina,
                //amount = selected,
                search = buscar
            };
            DataTable data = ModalidadesServices.List(buscar);
            //if (data==null)
            //{
            //    DataRow dataRow = dataGridViewJN1.NewRowIndex
            //    dataGridViewJN1.Rows.Add()
            //}

            dataGridViewJN1.DataSource = data;// obj.Data;
        }

        public override void Agregar()
        {
            Add add = new Add();
            ShowForm(add);
        }

        public override void CellContentDGV(DataGridViewCellEventArgs e)
        {

            // Editamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[0].Selected)
            {
                // Objeto con la data que se selecciono.
                tbModalidades objModalidades = new tbModalidades()
                {
                    Mda_Id = Convert.ToInt32(dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value),
                    Mda_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString()
                };
                Add.Send(objModalidades);
            }

            // Eliminamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[2].Selected)
            {
                Warning.ShowDialog("Desea eliminar esta fila?");
                if (Warning.isOk())
                {
                    tbModalidades objModalidades = new tbModalidades()
                    {
                        Mda_Id = (int)dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value,
                        //Mda_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString()
                    };
                    Boolean resultService = ModalidadesServices.Remove(objModalidades.Mda_Id);
                    DataGridViewFill();
                    if (resultService)
                    {
                        Alert.Show(Alert.enmType.Error, "No se ha podido eliminar la fila.", "Error");
                    }
                }
            }

        }


        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean CamposVacios;
            CamposVacios = Validation.CamposVacios(this);
            MessageBox.Show(CamposVacios.ToString());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataGridViewFill(txtBuscar.Text);
        }

        #endregion Eventos

        #region Metodos

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
        //    System.Collections.Generic.List<tbModalidades> lista = new System.Collections.Generic.List<tbModalidades>();
        //    lista.Add(new tbModalidades()
        //    {
        //        //mda_Descripcion = 
        //    });
        //    string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        //    //pictureBox1.Image = Image.FromFile(path+"/Content/image");
        //    MessageBox.Show(path);

        //}

        #endregion Metodos



        //private void jnButton1_Click(object sender, EventArgs e)
        //{
        //    ///var obj = ModalidadesServices.List("");
        //    PdfCustom.DataSource(this.Text, dataGridViewJN1);
        //}

        //private void jnButton2_Click(object sender, EventArgs e)
        //{
        //    //string[] ignore = new string[] { "Editar", "Detalle", "Eliminar" };
        //    Excel excel = new Excel();
        //    ///var obj = ModalidadesServices.List("");
        //    ////excel.DataSource(obj);
        //}


    }

    //public class DataGridHeaderText
    //{
    //    public string HeaderText { get; set; }
    //    public bool Visible { get; set; }
    //}

}
