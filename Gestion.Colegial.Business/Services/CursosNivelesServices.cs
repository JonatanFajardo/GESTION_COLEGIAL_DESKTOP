using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class CursosNivelesServices
    {
        #region Metodos

        private static CursosNivelesRepository objDato = new CursosNivelesRepository();

        public static async Task<DataTable> List(string sear)
        {
            var obj = await objDato.List(sear);
            return obj;
        }

        public static async Task<Boolean>Add(tbCursosNiveles entidad)
        {
            return await objDato.Add(entidad);
        }

        public static async Task<Boolean> Edit(tbCursosNiveles entidad)
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
