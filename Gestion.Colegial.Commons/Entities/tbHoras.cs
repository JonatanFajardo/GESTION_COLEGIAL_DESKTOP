
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbHoras
    {

        public int Hor_Id { get; set; }
        public string Hor_Hora { get; set; }
        public bool Hor_EsEliminado { get; set; }
        public int Hor_UsuarioRegistra { get; set; }
        public System.DateTime Hor_FechaRegistra { get; set; }
        public Nullable<int> Hor_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Hor_FechaModifica { get; set; }


    }
}
