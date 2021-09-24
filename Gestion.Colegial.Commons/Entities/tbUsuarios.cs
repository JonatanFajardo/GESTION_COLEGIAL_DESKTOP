
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbUsuarios
    {
        public int Usu_Id { get; set; }
        public int Emp_Id { get; set; }
        public string Usu_Name { get; set; }
        public Nullable<int> Con_Id { get; set; }
        public byte[] Usu_ContrasenaRecuperacion { get; set; }
        public int Rol_Id { get; set; }
        public string Usu_Ip { get; set; }
        public bool Usu_EsActivo { get; set; }
        public Nullable<bool> Usu_Suspendido { get; set; }
        public Nullable<bool> Usu_EsEliminado { get; set; }
        public Nullable<System.DateTime> Usu_FechaCreacion { get; set; }
        public Nullable<System.DateTime> Usu_fechaModificacion { get; set; }
    }
}
