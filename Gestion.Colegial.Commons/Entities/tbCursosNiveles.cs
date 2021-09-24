
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbCursosNiveles
    {
        public int Cun_Id { get; set; }
        public string Cun_Descripcion { get; set; }
        public bool Cun_EsEliminado { get; set; }
        public int Cun_UsuarioRegistra { get; set; }
        public System.DateTime Cun_FechaRegistra { get; set; }
        public Nullable<int> Cun_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Cun_FechaModifica { get; set; }
    }
}
