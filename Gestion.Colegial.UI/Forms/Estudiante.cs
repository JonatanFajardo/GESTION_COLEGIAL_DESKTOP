using Gestion.Colegial.UI.FormsBase;
using System;

namespace Gestion.Colegial.UI.Forms
{
    public partial class Estudiante : FormBase
    {
        public Estudiante()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            nameForm("Estudiante");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        public async override void Agregar()
        {
            Estudiante_Add form = new Estudiante_Add();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {

        }
    }
}
