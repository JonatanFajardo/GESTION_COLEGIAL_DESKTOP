
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbNotas
    {
        public int Not_Id { get; set; }
        public int Not_Nota { get; set; }
        public int Mat_Id { get; set; }
        public int Sem_Id { get; set; }
        public int Pac_Id { get; set; }
        public System.DateTime Not_Año { get; set; }
        public bool Not_EsActivo { get; set; }
        public bool Not_EsEliminado { get; set; }
        public int Not_UsuarioRegistra { get; set; }
        public System.DateTime Not_FechaRegistra { get; set; }
        public Nullable<int> Not_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Not_FechaModifica { get; set; }

    }
}
