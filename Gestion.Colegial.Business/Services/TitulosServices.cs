using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;

namespace Gestion.Colegial.Business.Services
{
    public class TitulosServices
    {
        #region Metodos

        private static TitulosRepository objDato = new TitulosRepository();

        public static DataTable List(string sear)
        {
            var obj = objDato.List(sear);
            return obj;
        }

        public static Boolean Add(tbTitulos entidad)
        {
            return objDato.Add(entidad);
        }

        public static Boolean Edit(tbTitulos entidad)
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
