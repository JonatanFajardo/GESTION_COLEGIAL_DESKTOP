
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbMaterias
    {

        public int Mat_Id { get; set; }
        public string Mat_Nombre { get; set; }
        public int Dur_Id { get; set; }
        public bool EsActivo { get; set; }
        public bool Mat_EsEliminado { get; set; }
        public int Mat_UsuarioRegistra { get; set; }
        public System.DateTime Mat_FechaRegistra { get; set; }
        public Nullable<int> Mat_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Mat_FechaModifica { get; set; }

    }
}
