using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Extensions;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Home
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //Estilos DataGridView
            dataGridViewJN1.RowTemplate.DividerHeight = 1;
            dataGridViewJN1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewJN1.ColumnHeadersHeight = 45;
            dataGridViewJN1.RowTemplate.DividerHeight = 1 / 3;//tamaño de linea row;
            dataGridViewJN1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            load();
        }

        private async void load()
        {
            Answer Alumnos = await HomeService.AlumnosList();
            Answer Encargados = await HomeService.EncargadosList();
            Answer Empleados = await HomeService.EmpleadosList();
            Answer Eventos = await HomeService.EventosList();
            pnLoading.Visible = true;

            if (Alumnos.Access)
                lbCountAlumnos.Text = "0";

            if (Encargados.Access)
                lbCountEmpleados.Text = "0";

            if (Empleados.Access)
                lbCountAlumnos.Text = "0";

            lbCountAlumnos.Text = Alumnos.Data.Rows.Count.ToString();
            lbCountEncargados.Text = Encargados.Data.Rows.Count.ToString();
            lbCountEmpleados.Text = Empleados.Data.Rows.Count.ToString();
            dataGridViewJN1.DataSource = Eventos.Data;
            pnLoading.Visible = false;
        }

    }
}
