namespace Gestion.Colegial.DataAccess
{
    public class Connection
    {
        // Cadena
        private static string sql = Properties.Settings.Default.CN;

        public static string Sql { get => sql; }

        //private SqlConnection CN = new SqlConnection("Data Source=SERVIDOREB;Initial Catalog=Gestion.Colegial;Integrated Security=True;Pooling=False");

        // Metodos
        //public static string Sql()
        //{
        //    return CN;
        //}
    }
}