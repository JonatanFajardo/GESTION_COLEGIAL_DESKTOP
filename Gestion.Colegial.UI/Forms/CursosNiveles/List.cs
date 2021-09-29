using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Helpers.Export;
using Gestion.Colegial.Business.Helpers.ExportCustom;
using Gestion.Colegial.Business.Messagebox;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using JNControls.Controles;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Helpers.Export;
using Gestion.Colegial.Business.Helpers.ExportCustom;
using Gestion.Colegial.Business.Messagebox;
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

namespace Gestion.Colegial.UI.Forms.CursosNiveles
{
    public partial class List : FormBase
    {
        public List()
        {
            InitializeComponent();

            DataGridViewFill();

            // Configuraciones DGV

            // Agregado de botones de accion.
            List<DGVHeader> actionButtons = new List<DGVHeader>()
            {
                new DGVHeader(){Name = " ", Size = 65 },
                new DGVHeader(){Name = "Acciones", Size = 65 },
                new DGVHeader(){Name = "  ", Size = 65 },
            };
            dataGridViewJN1.AddBtn(actionButtons);

            // Setea nombres del header.
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
            // Peticion de la data
            DataTable data = CursosNivelesServices.List(buscar);
            //if (data==null)
            //{
            //    DataRow dataRow = dataGridViewJN1.NewRowIndex
            //    dataGridViewJN1.Rows.Add()
            //}

            // Cargando DGV
            dataGridViewJN1.DataSource = data;// obj.Data;
        }


        #region FuncionalidadesDGV
        private void jnButton1_Click(object sender, EventArgs e)
        {
            ///var obj = CursosNivelesServices.List("");
            PdfCustom.DataSource(this.Text, dataGridViewJN1);
        }

        private void jnButton2_Click(object sender, EventArgs e)
        {
            //string[] ignore = new string[] { "Editar", "Detalle", "Eliminar" };
            Excel excel = new Excel();
            ///var obj = CursosNivelesServices.List("");
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
        public override void Agregar()
        {
            Add add = new Add();
            ShowForm(add);
        }

        /// <summary>
        /// Edita o elimina registros en funcion de lo seleccionado en el DGV.
        /// </summary>
        /// <param name="e">Evento.</param>
        public override void CellContentDGV(DataGridViewCellEventArgs e)
        {

            // Editamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[0].Selected)
            {
                // Objeto con la data que se selecciono.
                tbCursosNiveles objCursosNiveles = new tbCursosNiveles()
                {
                    Cun_Id = Convert.ToInt32(dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value),
                    Cun_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString()
                };
                Add.Send(objCursosNiveles);
            }

            // Eliminamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[2].Selected)
            {
                Warning.ShowDialog("Desea eliminar esta fila?");
                if (Warning.isOk())
                {
                    tbCursosNiveles objCursosNiveles = new tbCursosNiveles()
                    {
                        Cun_Id = (int)dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value,
                        //Mda_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString()
                    };
                    Boolean resultService = CursosNivelesServices.Remove(objCursosNiveles.Cun_Id);
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
        //    System.Collections.Generic.List<tbCursosNiveles> lista = new System.Collections.Generic.List<tbCursosNiveles>();
        //    lista.Add(new tbCursosNiveles()
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
