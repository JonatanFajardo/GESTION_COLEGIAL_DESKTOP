using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Utilities;
using Gestion.Colegial.Commons.Extensions;
using GESTION_COLEGIAL.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class EventosServices
    {
        #region Metodos

        // Eventos 

        public static async Task<Answer> List()
        {
            try
            {
                //Peticion.
                List<PR_tbEventos_ListResult> ApiResult = await ApiRequests.List<PR_tbEventos_ListResult>(ApiUrl.Eventos.List);
                if (ApiResult is null)
                    goto ErrorResult;
                //Configuramos datatable.
                DataTable result = new DataTable();
                result = ApiResult.ToList().ToDataTable();
                result.Columns[0].ColumnName = "Linea";
                result.Columns[1].ColumnName = "Nombre";
                result.Columns[2].ColumnName = "Descripción";
                result.Columns[3].ColumnName = "Fecha";
                result.Columns[4].ColumnName = "Hora";
                result.Columns[5].ColumnName = "Concluido";
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
                PR_tbEventos_FindResult ApiResult = await ApiRequests.Find<PR_tbEventos_FindResult>(ApiUrl.Eventos.Find, identifier);
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

        public static async Task<Boolean> Add(tbEventos entity)
        {
            try
            {
                return await ApiRequests.Create(ApiUrl.Eventos.Create, entity);
            }
            catch (Exception error)
            {
                return ErrorLog.Incidents(error);
            }
        }

        public static async Task<Boolean> Edit(tbEventos entity)
        {
            try
            {
                return await ApiRequests.Edit(ApiUrl.Eventos.Update, entity);
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
