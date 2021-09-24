
namespace Gestion.Colegial.Commons.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class tbPersonas
    {

        public int Per_Id { get; set; }
        public string Per_Identidad { get; set; }
        public string Per_PrimerNombre { get; set; }
        public string Per_SegundoNombre { get; set; }
        public string Per_ApellidoPaterno { get; set; }
        public string Per_ApellidoMaterno { get; set; }
        public System.DateTime Per_FechaNacimiento { get; set; }
        public string Per_CorreoElectronico { get; set; }
        public string Per_Telefono { get; set; }
        public string Per_Direccion { get; set; }
        public string Per_Sexo { get; set; }
        public bool Per_EsActivo { get; set; }
        public bool Per_EsEliminado { get; set; }
        public int Per_UsuarioRegistra { get; set; }
        public System.DateTime Per_FechaRegistra { get; set; }
        public Nullable<int> Per_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Per_FechaModifica { get; set; }

    }
}
