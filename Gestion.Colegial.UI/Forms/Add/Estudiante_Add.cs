using Gestion.Colegial.UI.FormsBase;
using System;

namespace Gestion.Colegial.UI.Forms
{
    public partial class Estudiante_Add : Add_Base
    {
        public Estudiante_Add()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}