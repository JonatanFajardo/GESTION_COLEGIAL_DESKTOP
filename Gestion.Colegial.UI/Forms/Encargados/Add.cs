using Gestion.Colegial.UI.FormsBase;

namespace Gestion.Colegial.UI.Forms.Encargados
{
    public partial class Add : Add_Base
    {
        // Instancia del formulario principal de la seccion list.
        Encargados.List _list;
        
        public Add(){}
        public Add(List list)
        {
            InitializeComponent();
            //load();
            _list = list;
        }
    }
}
