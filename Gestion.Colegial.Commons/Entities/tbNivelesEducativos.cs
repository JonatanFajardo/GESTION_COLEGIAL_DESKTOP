
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbNivelesEducativos
    {
        public int Niv_Id { get; set; }
        public string Niv_Descripcion { get; set; }
        public bool Niv_EsActivo { get; set; }
        public bool Niv_EsEliminado { get; set; }
        public int Niv_UsuarioRegistra { get; set; }
        public System.DateTime Niv_FechaRegistra { get; set; }
        public Nullable<int> Niv_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Niv_FechaModifica { get; set; }


    }
}
