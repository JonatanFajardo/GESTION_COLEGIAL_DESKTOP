using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Utilities;
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
    public class HorasServices
    {
        #region Metodos

        // Horas 

        public static async Task<Answer> List()
        {
            try
            {
                //Peticion.
                List<PR_tbHoras_ListResult> ApiResult = await ApiRequests.List<PR_tbHoras_ListResult>(ApiUrl.Horas.List);
                if (ApiResult is null)
                    goto ErrorResult;
                //Configuramos datatable.
                DataTable result = new DataTable();
                result = ApiResult.ToList().ToDataTable();
                result.Columns[0].ColumnName = "Linea";
                result.Columns[1].ColumnName = "Descripción";
                //Encapsulamos informacion de respuesta.
                Answer answer = new Answer();
                answer.Data = result;
                answer.Access = false;
                answer.Message = OperationMessage.Ok;
                return answer;
            }
            catch (Exception error)
            {
                ErrorLog.Incidents(error);
                goto ErrorResult;
            }

        ErrorResult:
            Answer answerError = new Answer();
            answerError.Message = OperationMessage.Error;
            answerError.Access = true;
            return answerError;
        }

        public static async Task<Answer> ListOne(int identifier)
        {
            try
            {
                PR_tbHoras_FindResult ApiResult = await ApiRequests.Find<PR_tbHoras_FindResult>(ApiUrl.Horas.Find, identifier);
                if (ApiResult is null)
                    goto ErrorResult;

                Answer answer = new Answer();
                answer.Data = ApiResult;
                answer.Access = false;
                answer.Message = OperationMessage.Ok;
                return answer;
            }
            catch (Exception error)
            {
                ErrorLog.Incidents(error);
                goto ErrorResult;
            }

        ErrorResult:
            Answer answerError = new Answer();
            answerError.Message = OperationMessage.Error;
            answerError.Access = true;
            return answerError;
        }

        public static async Task<Boolean> Add(tbHoras entity)
        {
            try
            {
                return await ApiRequests.Create(ApiUrl.Horas.Create, entity);
            }
            catch (Exception error)
            {
                return ErrorLog.Incidents(error);
            }
        }

        public static async Task<Boolean> Edit(tbHoras entity)
        {
            try
            {
                return await ApiRequests.Edit(ApiUrl.Horas.Update, entity);
            }
            catch (Exception error)
            {
                return ErrorLog.Incidents(error);
            }
        }

        public static async Task<Boolean> Remove(int identifier)
        {
            try
            {
                return await ApiRequests.Delete(ApiUrl.Alumnos.Delete, identifier);
            }
            catch (Exception error)
            {
                return ErrorLog.Incidents(error);
            }
        }

        #endregion Metodos

    }
}
