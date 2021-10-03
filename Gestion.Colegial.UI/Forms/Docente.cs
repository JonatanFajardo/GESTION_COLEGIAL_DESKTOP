//using Gestion.Colegial.Commons.Clases;
using Gestion.Colegial.UI.FormsBase;
using System;

namespace Gestion.Colegial.UI.Forms
{
    public partial class Docente : FormBase
    {
        ///*===============================================
        //                 REFERENCIAS
        //================================================*/
        //private B_Docente objNegocio = new B_Docente();
        //E_Docente e_Docente = new E_Docente();
        ///*===============================================
        //          Constructor e inicializacion
        //================================================*/
        //public delegate void send(List<string> date);
        //public event send Send;
        //public Docente()
        //{
        //    InitializeComponent();
        //    init();
        //}
        //private void init()
        //{
        //    buscarTabla("");
        //    nameForm("Docente");


        //}

        ///*===============================================
        //                    METODOS
        //================================================*/
        //public static void IsOpenForm(Form form)
        //{
        //    bool isOpen = false;

        //    foreach (Form item in Application.OpenForms)
        //    {
        //        if (item.Text == form.Text)
        //        {
        //            isOpen = true;
        //            item.Focus();
        //        }
        //    }

        //    if (!isOpen)
        //    {

        //        form.Show();
        //    }
        //}

        //public void buscarTabla(string buscar)
        //{
        //    dataGridView1.DataSource = objNegocio.sear(buscar);
        //}

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{

        //}
        ////== METODO QUE ELIMINA FILAS
        //public async override void CellContentDGV(DataGridViewCellEventArgs e)
        //{//obtenemos indice y borramos registros

        //    //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        //    if (dataGridView1.Rows[e.RowIndex].Cells[1].Selected)
        //    {
        //        Warning.ShowDialog("Desea eliminar esta fila?");
        //        //DialogResult dialog = message.ShowDialog(); 
        //       // bool s = Warning.isOk();
        //        if (Warning.isOk())
        //        { 
        //            int delete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        //            objNegocio.delete(delete);
        //            buscarTabla("");
        //        }
        //    }

        //    if (dataGridView1.Rows[e.RowIndex].Cells[0].Selected)
        //    {
        //        //Warning.ShowDialog("Desea editar esta fila");
        //        Docente_Add form = new Docente_Add();
        //        List<string> date = new List<string>() {
        //        Logica.explode(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), 0),
        //        Logica.explode(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), 1),
        //        Logica.explode(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), 0),
        //        Logica.explode(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), 1),
        //        dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
        //        dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
        //        dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(),
        //        dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(),
        //        dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString()
        //        };
        //        // e_Docente.Cat_Id = dataGridView1.Rows[e.RowIndex].Cells[2].Value ;
        //        foreach (var item in date)
        //        {
        //            MessageBox.Show(item.ToString());

        //        }
        //        //Send(date);
        //        //form.Show();



        //        ////DialogResult dialog = message.ShowDialog(); 
        //        //// bool s = Warning.isOk();
        //        //if (Warning.isOk())
        //        //{
        //        //    int delete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        //        //    objNegocio.delete(delete);
        //        //    buscarTabla("");
        //        //}
        //    }
        //}

        //public async override void Agregar()
        //{
        //    Docente_Add form = new Docente_Add();
        //    IsOpenForm(form);
        //    //form.Show();
        //}

        //public async override void buscar()
        //{

        //}
        ////== HACE LA BUSQUEDA
        //private void txtBuscar_TextChanged(object sender, EventArgs e)
        //{
        //    buscarTabla(txtBuscar.Text);
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
