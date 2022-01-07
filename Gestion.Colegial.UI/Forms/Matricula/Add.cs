using Gestion.Colegial.UI.FormsBase;

namespace Gestion.Colegial.UI.Forms.Matricula
{
    public partial class Add : Add_Base
    {
        // Instancia del formulario principal de la seccion list.
        Matricula.List _list;

        public Add() { InitializeComponent(); }
        public Add(List list)
        {
            InitializeComponent();
            //load();
            _list = list;
        }
    }
}
