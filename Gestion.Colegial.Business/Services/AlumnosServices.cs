using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class AlumnosServices
    {
        #region Metodos

        private static AlumnosRepository objDato = new AlumnosRepository();

        public static async Task<DataTable> List(string sear)
        {
            var obj = await objDato.List(sear);
            return obj;
        }

        //public static async Task<DataTable> ListOne(string sear)
        //{
        //    var obj = await objDato.(sear);
        //    return obj;
        //}

        public static async Task<Boolean> Add(tbAlumnos entity)
        {
            return await objDato.Add(entity);
        }

        public static async Task<Boolean> Edit(tbAlumnos entity)
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