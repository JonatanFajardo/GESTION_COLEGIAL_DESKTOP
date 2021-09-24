using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;

namespace Gestion.Colegial.Business.Services
{
    public class ModalidadesServices
    {
        //====================================================//
        //                    INSTANCIACION
        //====================================================//

        #region Metodos

        private static ModalidadesRepository objDato = new ModalidadesRepository();

        public static DataTable List(string sear)
        {
            var obj = objDato.List(sear);
            return obj;
        }

        public static Boolean Add(tbModalidades entidad)
        {
            return objDato.Add(entidad);
        }

        public static Boolean Edit(tbModalidades entidad)
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
