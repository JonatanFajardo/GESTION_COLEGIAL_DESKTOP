
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbCursosNombres
    {

        public int Cno_Id { get; set; }
        public string Cno_Descripcion { get; set; }
        public bool Cno_EsEliminado { get; set; }
        public int Cno_UsuarioRegistra { get; set; }
        public System.DateTime Cno_FechaRegistra { get; set; }
        public Nullable<int> Cno_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Cno_FechaModifica { get; set; }


    }
}
