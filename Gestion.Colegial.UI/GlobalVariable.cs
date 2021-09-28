using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Colegial.UI
{
    public static class GlobalVariable
    {
        public static class tbUsuario
        {
            public static int Usu_Id { get; set; }
            public static int Emp_Id { get; set; }
            public static string Usu_Name { get; set; }
            public static Nullable<int> Con_Id { get; set; }
            public static byte[] Usu_ContrasenaRecuperacion { get; set; }
            public static int Rol_Id { get; set; }
            public static string Usu_Ip { get; set; }
            public static bool Usu_EsActivo { get; set; }
        }
    }
}
