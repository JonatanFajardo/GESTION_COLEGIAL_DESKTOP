namespace Gestion.Colegial.DataAccess
{
    public class Connection
    {

        // Cadena
        private readonly static string CN = Properties.Settings.Default.CN;
        //private SqlConnection CN = new SqlConnection("Data Source=SERVIDOREB;Initial Catalog=Gestion.Colegial;Integrated Security=True;Pooling=False");

        // Metodos
        public static string Sql()
        {
            return CN;
        }

    }
}
