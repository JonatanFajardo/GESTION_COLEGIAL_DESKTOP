
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbSemestres
    {

        public int Sem_Id { get; set; }
        public string Sem_Descripcion { get; set; }
        public bool Sem_EsActivo { get; set; }
        public bool Sem_EsEliminado { get; set; }
        public int Sem_UsuarioRegistra { get; set; }
        public System.DateTime Sem_FechaRegistra { get; set; }
        public Nullable<int> Sem_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Sem_FechaModifica { get; set; }


    }
}
