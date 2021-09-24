﻿using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;

namespace Gestion.Colegial.Business.Services
{
    public class SemestresServices
    {
        #region Metodos

        private static SemestresRepository objDato = new SemestresRepository();
        public static DataTable List(string sear)
        {
            var obj = objDato.List(sear);
            return obj;
        }

        public static Boolean Add(tbSemestres entidad)
        {
            return objDato.Add(entidad);
        }

        public static Boolean Edit(tbSemestres entidad)
        {
            return objDato.Edit(entidad);
        }

        public static Boolean Remove(int entidad)
        {
            return objDato.Remove(entidad);
        }

        #endregion Metodos

    }
}
