using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Helpers;
using System;
using System.IO;

namespace Gestion.Colegial.DataAccess.Repositories.bitacoras
{
    public class ErrorLogRepository
    {
        public static void Add(Exception exception)
        {
            string pathFolder = Directory.GetCurrentDirectory();
            string nameFile = $"Log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}";
            string content = "";

            content += DateTime.Now + " - " + pathFolder + " - " + exception.Message + " - " + exception.InnerException + Environment.NewLine;

            Create.Path = pathFolder;
            Create.FolderName = "Log";
            Create.Folder();
            Create.File(nameFile, "txt", content);
        }

        public static void Add(Answer answer)
        {
           

        }

    }


}
