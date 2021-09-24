using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.FormsBase
{
    public partial class Add_Base : Form
    {
        public Add_Base()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void OnClick()
        {

        }




        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            OnClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
