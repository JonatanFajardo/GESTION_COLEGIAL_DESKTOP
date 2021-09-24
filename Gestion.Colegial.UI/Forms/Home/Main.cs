using Gestion.Colegial.Business.Helpers;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Home
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            pnHeader.BackColor = Variable.Primary;
        }

        private void lblEstudiante_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Forms.Estudiante());

        }

        private void lblDocente_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Forms.Docente());


        }

        private void lblAula_Click(object sender, EventArgs e)
        {

        }

        private void lblMateria_Click(object sender, EventArgs e)
        {

        }

        private void lblCalificaciones_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {
            //Forms.Matricula matricula= new Matricula();
            //this.Hide();
            //matricula.Show();
            OpenFormInPanel(new Forms.Docente());
        }

        public void OpenFormInPanel(object formhijo)
        {
            if (this.pnContenedor.Controls.Count > 0)

                this.pnContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(fh);
            this.pnContenedor.Tag = fh;
            fh.Show();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
