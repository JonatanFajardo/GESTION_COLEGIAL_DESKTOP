//using Gestion.Colegial.Business.Extensions;
//using Gestion.Colegial.Commons.Entities;
//using Gestion.Colegial.DataAccess.Repositories.app;
//using System;
//using System.Data;
//using System.Threading.Tasks;

//namespace Gestion.Colegial.Business.Services
//{
//    public class HorarioAlumnosServices
//    {
//        #region Metodos

//        // HorarioAlumnos HorarioAlumnos

//        public static async Task<DataTable> List(string sear)
//        {
//            var obj = await objDato.List(sear);
//            return obj;
//        }

//        public static async Task<Boolean> Add(tbHorarioAlumnos entity)
//        {
//            try
//            {
//            return await ApiRequests.Create(ApiUrl.Semestres.Create, entity);}
//            catch (Exception error)
//            {
//               return ErrorLog.Incidents(error);
//            }
//        }

//        public static async Task<Boolean> Edit(tbHorarioAlumnos entity)
//        {
//            try
//            {
//            return await ApiRequests.Edit(ApiUrl.Semestres.Update, entity);
//        }
//            catch (Exception error)
//            {
//               return ErrorLog.Incidents(error);
//            }
//        }

//        public static async Task<Boolean> Remove(int identifier)
//        {
//            try
//            {
//            return await ApiRequests.Delete(ApiUrl.Alumnos.Delete, identifier);
//            }
//            catch (Exception error)
//            {
//               return ErrorLog.Incidents(error);
//            }
//        }

//        #endregion Metodos

//    }
//}
