using Gestion.Colegial.UI.FormsBase;
using System;

namespace Gestion.Colegial.UI.Forms
{
    public partial class Estudiante_Add : Add_Base
    {
        public Estudiante_Add()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
