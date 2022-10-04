using Gestion.Colegial.UI.FormsBase;

namespace Gestion.Colegial.UI.Forms.Alumnos
{
    public partial class Add : Add_Base
    {
        // Instancia del formulario principal de la seccion list.
        private Alumnos.List _list;

        private int _id;

        public Add()
        { InitializeComponent(); }

        public Add(int id, List list)
        {
            InitializeComponent();
            _id = id;
            _list = list;
        }
    }
}