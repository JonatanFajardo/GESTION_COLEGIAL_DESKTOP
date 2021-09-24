
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbCursos
    {
        public int Cur_Id { get; set; }
        public int Cno_Id { get; set; }
        public int Aul_Id { get; set; }
        public int Sec_Id { get; set; }
        public int Niv_Id { get; set; }
        public int Mda_Id { get; set; }
        public bool Cur_EsActivo { get; set; }
        public bool Cur_EsEliminado { get; set; }
        public int Cur_UsuarioRegistra { get; set; }
        public System.DateTime Cur_FechaRegistra { get; set; }
        public Nullable<int> Cur_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Cur_FechaModifica { get; set; }


    }
}
