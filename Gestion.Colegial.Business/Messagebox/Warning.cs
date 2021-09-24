using System;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Messagebox
{
    public partial class Warning : MessageBase
    {
        static bool validar = false;
        public Warning(string _mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = _mensaje;
            init();
        }
        //validar regresa true asi que asi validamos que se haga false de nuevo
        private void init()
        {
            if (validar == true)
            {
                validar = false;
            }
        }

        public override void Aceptar()
        {
            this.DialogResult = DialogResult.OK;
            validar = true;
        }
        public static void ShowDialog(string mensaje)
        {
            Warning warning = new Warning(mensaje);
            warning.ShowDialog();
        }

        public static Boolean isOk()
        {
            return validar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
