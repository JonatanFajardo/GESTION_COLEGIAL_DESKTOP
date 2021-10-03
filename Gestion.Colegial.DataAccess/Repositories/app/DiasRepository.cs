using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class DiasRepository : Interfaces.IRepositories<tbDias>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbDias_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbDias_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dia_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbDias_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dia_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbDias entidad)
        {
            const String commandText = "PR_tbDias_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Descripcion", DbType = DbType.String, Value = entidad.Dia_Descripcion},
                new SqlParameter(){ParameterName= "@Dia_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Dia_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbDias entidad)
        {
            const String commandText = "PR_tbDias_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entidad.Dia_Id},
                new SqlParameter(){ParameterName= "@Dia_Descripcion", DbType = DbType.String, Value = entidad.Dia_Descripcion},
                new SqlParameter(){ParameterName= "@Dia_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Dia_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbDias_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
