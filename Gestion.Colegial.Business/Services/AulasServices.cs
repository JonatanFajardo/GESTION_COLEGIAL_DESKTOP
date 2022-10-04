using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class AulasServices
    {
        #region Metodos

        private static AulasRepository objDato = new AulasRepository();

        public static async Task<DataTable> List(string sear)
        {
            var obj = await objDato.List(sear);
            return obj;
        }

        public static async Task<Boolean> Add(tbAulas entity)
        {
            return await objDato.Add(entity);
        }

        public static async Task<Boolean> Edit(tbAulas entity)
        {
            return await objDato.Edit(entity);
        }

        public static async Task<Boolean> Remove(int identifier)
        {
            return await objDato.Remove(identifier);
        }

        #endregion Metodos
    }
}