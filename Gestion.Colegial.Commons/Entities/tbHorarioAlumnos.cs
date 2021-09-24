
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbHorarioAlumnos
    {
        public int HoAl_Id { get; set; }
        public int Cur_Id { get; set; }
        public int Cun_Id { get; set; }
        public int Mat_Id { get; set; }
        public int HoAl_HoraInicio { get; set; }
        public int HoAl_HoraFinaliza { get; set; }
        public int Dia_Id { get; set; }
        public bool HoAl_EsEliminado { get; set; }
        public int HoAl_UsuarioRegistra { get; set; }
        public System.DateTime HoAl_FechaRegistra { get; set; }
        public Nullable<int> HoAl_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> HoAl_FechaModifica { get; set; }

    }
}
