
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbEstados
    {


        public int Est_Id { get; set; }
        public string Est_Descripcion { get; set; }
        public bool Est_EsEliminado { get; set; }
        public int Est_UsuarioRegistra { get; set; }
        public System.DateTime Est_FechaRegistra { get; set; }
        public Nullable<int> Est_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Est_FechaModifica { get; set; }

    }
}
