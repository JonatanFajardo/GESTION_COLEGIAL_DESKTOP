
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbHorarioProfesores
    {
        public int HoPr_Id { get; set; }
        public int Cur_Id { get; set; }
        public int Cun_Id { get; set; }
        public int HoPr_HoraInicio { get; set; }
        public int HoPr_HoraFinaliza { get; set; }
        public int Dia_Id { get; set; }
        public bool HoPr_EsEliminado { get; set; }
        public int HoPr_UsuarioRegistra { get; set; }
        public System.DateTime HoPr_FechaRegistra { get; set; }
        public Nullable<int> HoPr_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> HoPr_FechaModifica { get; set; }
    }
}
