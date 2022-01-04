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
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string value)
        {
            const string commandText = "PR_tbAulas_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Aul_Id", DbType = DbType.Int32, Value = value },
            };
            DataTable result = await Search(value, commandText, sqlParameters);
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

        public async Task<Boolean> Add(tbAulas entidad)
        {
            const String commandText = "PR_tbAulas_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Descripcion", DbType = DbType.String, Value = entidad.Aul_Descripcion},
                new SqlParameter(){ParameterName= "@Aul_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Aul_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbAulas entidad)
        {
            const String commandText = "PR_tbAulas_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entidad.Aul_Id},
                new SqlParameter(){ParameterName= "@Aul_Descripcion", DbType = DbType.String, Value = entidad.Aul_Descripcion},
                new SqlParameter(){ParameterName= "@Aul_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Aul_UsuarioModifica},
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
