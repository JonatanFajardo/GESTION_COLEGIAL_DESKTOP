using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class EncargadosRepository : BaseRepository, Interfaces.IRepositories<tbEncargados>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbEncargados_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbEncargados_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Enc_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbEncargados_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Enc_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbEncargados entity)
        {
            const String commandText = "PR_tbEncargados_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entity.Per_Id},
                new SqlParameter(){ParameterName= "@Enc_Ocupacion", DbType = DbType.String, Value = entity.Enc_Ocupacion}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbEncargados entity)
        {
            const String commandText = "PR_tbEncargados_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Enc_Id", DbType = DbType.Int32, Value = entity.Enc_Id},
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entity.Per_Id},
                new SqlParameter(){ParameterName= "@Enc_Ocupacion", DbType = DbType.String, Value = entity.Enc_Ocupacion},
                new SqlParameter(){ParameterName= "@Enc_EsActivo", DbType = DbType.String, Value = entity.Enc_EsActivo}
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbEncargados_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Enc_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
