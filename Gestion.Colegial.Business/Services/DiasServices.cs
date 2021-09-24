using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;

namespace Gestion.Colegial.Business.Services
{
    public class DiasServices
    {
        #region Metodos

        private static DiasRepository objDato = new DiasRepository();

        public static DataTable List(string sear)
        {
            var obj = objDato.List(sear);
            return obj;
        }

        public static Boolean Add(tbDias entidad)
        {
            return objDato.Add(entidad);
        }

        public static Boolean Edit(tbDias entidad)
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
