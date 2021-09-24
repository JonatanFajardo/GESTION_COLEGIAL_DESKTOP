
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbParciales
    {
        public int Pac_Id { get; set; }
        public string Pac_Descripcion { get; set; }
        public bool Pac_EsEliminado { get; set; }
        public int Pac_UsuarioRegistra { get; set; }
        public System.DateTime Pac_FechaRegistra { get; set; }
        public Nullable<int> Pac_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Pac_FechaModifica { get; set; }

    }
}
