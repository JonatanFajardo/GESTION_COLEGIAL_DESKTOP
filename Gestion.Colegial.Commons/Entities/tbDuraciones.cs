
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbDuraciones
    {


        public int Dur_Id { get; set; }
        public string Dur_Descripcion { get; set; }
        public bool Dur_EsEliminado { get; set; }
        public int Dur_UsuarioRegistra { get; set; }
        public System.DateTime Dur_FechaRegistra { get; set; }
        public Nullable<int> Dur_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Dur_FechaModifica { get; set; }

    }
}
