using Gestion.Colegial.UI.FormsBase;

namespace Gestion.Colegial.UI.Forms.Empleados
{
    public partial class Add : Add_Base
    {
        // Instancia del formulario principal de la seccion list.
        Empleados.List _list;

        public Add() { InitializeComponent(); }
        public Add(List list)
        {
            InitializeComponent();
            //load();
            _list = list;
        }

        private void label11_Click(object sender, System.EventArgs e)
        {

        }
    }
}
