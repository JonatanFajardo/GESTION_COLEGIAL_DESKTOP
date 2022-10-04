using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class DiasRepository : BaseRepository, Interfaces.IRepositories<tbDias>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbDias_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbDias_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dia_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbDias_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dia_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbDias entity)
        {
            const String commandText = "PR_tbDias_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Descripcion", DbType = DbType.String, Value = entity.Dia_Descripcion},
                new SqlParameter(){ParameterName= "@Dia_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Dia_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbDias entity)
        {
            const String commandText = "PR_tbDias_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entity.Dia_Id},
                new SqlParameter(){ParameterName= "@Dia_Descripcion", DbType = DbType.String, Value = entity.Dia_Descripcion},
                new SqlParameter(){ParameterName= "@Dia_UsuarioModifica", DbType = DbType.Int32, Value = entity.Dia_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbDias_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}