using Gestion.Colegial.UI.FormsBase;

namespace Gestion.Colegial.UI.Forms.Cursos
{
    public partial class Add : Add_Base
    {
        // Instancia del formulario principal de la seccion list.
        Cursos.List _list;

        public Add() { InitializeComponent(); }
        public Add(List list)
        {
            InitializeComponent();
            //load();
            _list = list;
        }
    }
}
