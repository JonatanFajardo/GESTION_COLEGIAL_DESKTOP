
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbParentescos
    {

        public int Par_Id { get; set; }
        public string Par_Descripcion { get; set; }
        public bool Par_EsEliminado { get; set; }
        public int Par_UsuarioRegistra { get; set; }
        public System.DateTime Par_FechaRegistra { get; set; }
        public Nullable<int> Par_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Par_FechaModifica { get; set; }

    }
}
