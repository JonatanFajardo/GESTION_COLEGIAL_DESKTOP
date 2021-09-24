
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbModalidades
    {

        public int Mda_Id { get; set; }
        public string Mda_Descripcion { get; set; }
        public bool Mda_EsEliminado { get; set; }
        public int Mda_UsuarioRegistra { get; set; }
        public System.DateTime Mda_FechaRegistra { get; set; }
        public Nullable<int> Mda_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Mda_FechaModifica { get; set; }


    }
}
