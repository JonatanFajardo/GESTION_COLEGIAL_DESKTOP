namespace Gestion.Colegial.DataAccess.Repositories.bitacoras
{
    public class Log
    {
        //fecha
        //nombre equipo
        // descripcion error

        private string Path = "";

        public Log(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {


        }

        //private string GetNameFile()
        //{
        //    string nombre = "";

        //    nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

        //    return nombre;
        //}


    }
}
