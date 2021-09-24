
namespace Gestion.Colegial.Commons.Entities
{
    using System;

    public partial class tbSubMenu
    {
        public int Submen_Id { get; set; }
        public string Submen_Descripcion { get; set; }
        public string Submen_Url { get; set; }
        public Nullable<int> Men_Id { get; set; }

    }
}
