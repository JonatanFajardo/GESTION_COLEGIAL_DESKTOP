
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbTitulos
    {
        public int Tit_Id { get; set; }
        public string Tit_Descripcion { get; set; }
        public bool Tit_EsEliminado { get; set; }
        public int Tit_UsuarioRegistra { get; set; }
        public System.DateTime Tit_FechaRegistra { get; set; }
        public Nullable<int> Tit_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Tit_FechaModifica { get; set; }


    }
}
