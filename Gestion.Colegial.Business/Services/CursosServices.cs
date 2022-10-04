using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class CursosServices
    {
        #region Metodos

        private static CursosRepository objDato = new CursosRepository();

        public static async Task<DataTable> List(string sear = "")
        {
            var obj = await objDato.List(sear);
            return obj;
        }

        public static async Task<Boolean> Add(tbCursos entity)
        {
            return await objDato.Add(entity);
        }

        public static async Task<Boolean> Edit(tbCursos entity)
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