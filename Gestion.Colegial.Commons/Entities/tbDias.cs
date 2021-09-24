
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbDias
    {

        public int Dia_Id { get; set; }
        public string Dia_Descripcion { get; set; }
        public bool Dia_EsEliminado { get; set; }
        public int Dia_UsuarioRegistra { get; set; }
        public System.DateTime Dia_FechaRegistra { get; set; }
        public Nullable<int> Dia_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Dia_FechaModifica { get; set; }


    }
}
