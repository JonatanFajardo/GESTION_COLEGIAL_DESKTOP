﻿using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Helpers;
using System;
using System.IO;

namespace Gestion.Colegial.DataAccess.Repositories.bitacoras
{
    public class ErrorLogRepository
    {
        public static void Incidents(Exception exception)
        {
            string pathFolder = Directory.GetCurrentDirectory();
            string nameFile = $"Log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}";
            string content = "";

            content += "[FECHA] " + DateTime.Now + " [DIRECCION] " + pathFolder + " [MENSAJE] " + exception.Message + " [EXEPCION_INTERNA] " + exception.InnerException + Environment.NewLine;

            Create.Path = pathFolder;
            Create.FolderName = "Log";
            Create.Folder();
            Create.File(nameFile, "txt", content);
        }

        public static void Incidents(Answer answer)
        {


        }

    }


}
