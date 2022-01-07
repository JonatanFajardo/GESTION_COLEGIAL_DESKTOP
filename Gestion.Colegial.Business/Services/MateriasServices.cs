using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Repositories.app;
using Gestion.Colegial.DataAccess.Repositories.bitacoras;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class MateriasServices
    {
        #region Metodos

        private static MateriasRepository objDato = new MateriasRepository();

        public static async Task<Answer> List(string sear = "")
        {
            try
            {
                Answer answer = new Answer();
                DataTable result = await objDato.List(sear);
                result.Columns[0].ColumnName = "Linea";
                result.Columns[1].ColumnName = "Descripción";
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

        public static async Task<Boolean> Add(tbMaterias entity)
        {
            return await objDato.Add(entity);
        }

        public static async Task<Boolean> Edit(tbMaterias entity)
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
