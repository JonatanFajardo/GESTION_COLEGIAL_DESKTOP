
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbCargos
    {

        public int Car_Id { get; set; }
        public string Car_Descripcion { get; set; }
        public bool Car_EsEliminado { get; set; }
        public int Car_UsuarioRegistra { get; set; }
        public System.DateTime Car_FechaRegistra { get; set; }
        public Nullable<int> Car_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Car_FechaModifica { get; set; }


    }
}
