
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbSecciones
    {

        public int Sec_Id { get; set; }
        public string Sec_Descripcion { get; set; }
        public bool Sec_EsEliminado { get; set; }
        public int Sec_UsuarioRegistra { get; set; }
        public System.DateTime Sec_FechaRegistra { get; set; }
        public Nullable<int> Sec_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Sec_FechaModifica { get; set; }


    }
}
