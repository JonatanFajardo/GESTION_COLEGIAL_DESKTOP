using Gestion.Colegial.UI.FormsBase;

namespace Gestion.Colegial.UI.Forms.Aulas
{
    public partial class Add : Add_Base
    {
        // Instancia del formulario principal de la seccion list.
        Aulas.List _list;
        
        public Add(){}
        public Add(List list)
        {
            InitializeComponent();
            //load();
            _list = list;
        }


    }
}
