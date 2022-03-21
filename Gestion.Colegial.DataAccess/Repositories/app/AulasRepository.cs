using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class AulasRepository : BaseRepository, Interfaces.IRepositories<tbAulas>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbAulas_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Read(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbAulas_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Aul_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbAulas_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Aul_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbAulas entity)
        {
            const String commandText = "PR_tbAulas_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Descripcion", DbType = DbType.String, Value = entity.Aul_Descripcion},
                new SqlParameter(){ParameterName= "@Aul_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Aul_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbAulas entity)
        {
            const String commandText = "PR_tbAulas_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entity.Aul_Id},
                new SqlParameter(){ParameterName= "@Aul_Descripcion", DbType = DbType.String, Value = entity.Aul_Descripcion},
                new SqlParameter(){ParameterName= "@Aul_UsuarioModifica", DbType = DbType.Int32, Value = entity.Aul_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbAulas_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
