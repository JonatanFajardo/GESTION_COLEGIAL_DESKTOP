namespace Gestion.Colegial.Business.Messagebox
{
    public partial class Success : MessageBase
    {
        public Success(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }
        public Success(string mensaje, string title)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            lblTitulo.Text = title;
        }

        public static void ShowDialog(string Mensaje)
        {
            Success success = new Success(Mensaje);
            success.ShowDialog();
        }
        public static void ShowDialog(string Mensaje, string Titulo)
        {
            Success success = new Success(Mensaje, Titulo);
            success.ShowDialog();
        }

        public override void Aceptar()
        {
            this.Close();
        }
    }
}
