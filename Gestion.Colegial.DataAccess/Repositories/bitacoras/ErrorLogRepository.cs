using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Helpers;
using System;
using System.IO;

namespace Gestion.Colegial.DataAccess.Repositories.bitacoras
{
    public class ErrorLogRepository
    {
        public static void Add(object obj, Exception exception)
        {
            string pathFolder = Directory.GetCurrentDirectory();
            string nameFile = $"Log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}";
            string content = "";

            content += DateTime.Now + " - " + exception.Message + " - " + exception.InnerException + Environment.NewLine;

            Create.Path = "C:\\Users\\User\\Documents\\GitHub\\GESTION_COLEGIAL_DESKTOP\\Gestion.Colegial.UI\\bin\\Debug";
            Create.FolderName = "Log";
            Create.Folder();
            Create.File(nameFile, "txt", content);
        }

        public static void Add(Answer answer)
        {
           

        }

    }


}
