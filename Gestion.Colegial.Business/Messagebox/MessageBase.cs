using System;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Messagebox
{
    public partial class MessageBase : Form
    {
        public MessageBase()
        {
            InitializeComponent();
        }

        private void MessageBase_Load(object sender, EventArgs e)
        {
        }

        public virtual void Aceptar()
        {
        }

        private enmType _alert;

        public enmType Alert { get => _alert; set => _alert = value; }

        public enum enmType
        {
            Success,
            Warnin,
            Error,
            Information
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
    }
}