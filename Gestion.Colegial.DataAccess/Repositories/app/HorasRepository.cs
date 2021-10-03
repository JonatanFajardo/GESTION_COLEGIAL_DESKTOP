using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class HorasRepository : Interfaces.IRepositories<tbHoras>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbHoras_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbHoras_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Hor_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbHoras_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Hor_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbHoras entidad)
        {
            const String commandText = "PR_tbHoras_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Hor_Hora", DbType = DbType.String , Value = entidad.Hor_Hora},
                new SqlParameter(){ParameterName= "@Hor_UsuarioRegistra", DbType = DbType.Int32 , Value = entidad.Hor_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }


        public async Task<Boolean> Edit(tbHoras entidad)
        {
            const String commandText = "PR_tbHoras_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Hor_Id", DbType = DbType.Int32, Value = entidad.Hor_Id},
                new SqlParameter(){ParameterName= "@Hor_Hora", DbType = DbType.String , Value = entidad.Hor_Hora},
                new SqlParameter(){ParameterName= "@Hor_UsuarioModifica", DbType = DbType.Int32 , Value = entidad.Hor_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbHoras_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Hor_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
