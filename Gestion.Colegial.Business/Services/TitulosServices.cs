using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class TitulosServices
    {
        #region Metodos

        private static TitulosRepository objDato = new TitulosRepository();

        public static async Task<DataTable> List(string sear)
        {
            var obj = await objDato.List(sear);
            return obj;
        }

        public static async Task<Boolean> Add(tbTitulos entidad)
        {
            return await objDato.Add(entidad);
        }

        public static async Task<Boolean> Edit(tbTitulos entidad)
        {
            return await objDato.Edit(entidad);
        }

        public static async Task<Boolean> Remove(int entidad)
        {
            return await objDato.Remove(entidad);
        }

        #endregion Metodos

    }
}
