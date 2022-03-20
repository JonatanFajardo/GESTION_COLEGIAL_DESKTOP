using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class EncargadosServices
    {

        #region Metodos

        private static EncargadosRepository objDato = new EncargadosRepository();

        public static async Task<Answer> List(string sear = "")
        {
            try
            {
                Answer answer = new Answer();
                DataTable result = await objDato.List(sear);
                result.Columns[0].ColumnName = "Enc_Id";
                result.Columns[1].ColumnName = "Identidad";
                result.Columns[2].ColumnName = "Encargado";
                result.Columns[3].ColumnName = "Telefono";
                result.Columns[4].ColumnName = "Ocupacion";
                result.Columns[5].ColumnName = "Estado";
                answer.Data = result;
                if (answer.Data is null)
                {
                    goto ErrorResult;
                }
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
                Answer answer = new Answer();
                DataTable result = await objDato.ListOne(identifier);
                answer.Data = result.Mapear<tbEncargados>().FirstOrDefault();
                if (answer.Data is null)
                {
                    goto ErrorResult;
                }
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

        public static async Task<Boolean> Add(tbEncargados entity)
        {
            try
            {
                return await objDato.Add(entity);
            }
            catch (Exception error)
            {
                return true;
            }
        }

        public static async Task<Boolean> Edit(tbEncargados entity)
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