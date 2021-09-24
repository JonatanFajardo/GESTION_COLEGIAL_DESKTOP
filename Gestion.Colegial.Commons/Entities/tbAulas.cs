
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbAulas
    {
        public int Aul_Id { get; set; }
        public string Aul_Descripcion { get; set; }
        public bool Aul_EsEliminado { get; set; }
        public int Aul_UsuarioRegistra { get; set; }
        public System.DateTime Aul_FechaRegistra { get; set; }
        public Nullable<int> Aul_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Aul_FechaModifica { get; set; }
    }
}
