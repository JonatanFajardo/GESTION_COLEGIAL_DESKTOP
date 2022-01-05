using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class CargosServices
    {
        #region Metodos

        private static CargosRepository objDato = new CargosRepository();

        public static async Task<DataTable> List(string sear = "")
        {
            try
            {
                return  await objDato.List(sear);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<tbCargos> ListOne(int identifier)
        {
            try
            {
                DataTable result = await objDato.ListOne(identifier);
                return result.Mapear<tbCargos>().FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<Boolean> Add(tbCargos entity)
        {
            return await objDato.Add(entity);
        }

        public static async Task<Boolean> Edit(tbCargos entity)
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
