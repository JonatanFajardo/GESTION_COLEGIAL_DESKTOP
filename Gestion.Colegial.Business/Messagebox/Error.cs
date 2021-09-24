namespace Gestion.Colegial.Business.Messagebox
{
    public partial class Error : MessageBase
    {
        public Error(string _mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = _mensaje;
        }
        public static void ShowDialog(string mensaje)
        {
            Error error = new Error(mensaje);
            error.ShowDialog();
        }

        public override void Aceptar()
        {
            this.Close();
        }

    }
}
