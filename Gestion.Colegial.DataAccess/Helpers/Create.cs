﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Helpers
{
    public class Create
    {
        private static string _path;
        private static string _folderName;

        public static string Path { get => _path; set => _path = value; }
        public static string FolderName { get => _folderName; set => _folderName = value; }


        /// <summary>
        /// Crea un nuevo folder en la ruta especificada.
        /// </summary>
        /// <param name="path">Ruta en la cual se creara la carpeta.</param>
        /// <returns>
        /// Retorna
        /// 0 Si la carpeta se creo.
        /// 1 No pudo crearse.
        /// 2 Ya existe.
        /// </returns>
        //public static int Folder(string path)
        //{
        //    if (!Directory.Exists(path))
        //    {
        //        Directory.CreateDirectory(path);
        //        return 0;
        //    }
        //    else
        //    {
        //        return 2;
        //    }
        //}


        /// <summary>
        /// Crea un nuevo folder en la ruta especificada.
        /// </summary>
        /// <remarks>
        /// Requisito: Debe de llenarse la propiedad Path antes de utilizar el metodo.
        /// </remarks>
        /// <returns>
        /// Retorna
        /// 0 Si la carpeta se creo.
        /// 1 No pudo crearse.
        /// 2 Ya existe.
        /// </returns>
        public static int Folder()
        {
            string path = $"{_path}/{_folderName}";
            if (path != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Crea un archivo.
        /// </summary>
        /// <remarks>
        /// Requiere: Necesita llenar anticipadamente las propiedades Path y FolderName para su correcto funcionamiento.
        /// </remarks>
        /// <param name="name">Nombre del archivo.</param>
        /// <param name="extension">Tipo de extension.</param>
        /// <param name="writer">Contenidoa guardar.</param>
        /// <returns></returns>
        public static int File(string name, string extension, string writer)
        {
            string path = $"{_path}/{_folderName}";
            StreamWriter streamWriter = new StreamWriter($"{path}/{name}.{extension}", true);//EL parametro encoding nos permite evitar sobre escribir en todo el archivo.
            streamWriter.Write(writer);
            streamWriter.Flush();
            streamWriter.Close();
            return 0;
        }



    }
}
