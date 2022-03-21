using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ParentescosRepository : BaseRepository, Interfaces.IRepositories<tbParentescos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbParentescos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Read(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbParentescos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Par_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbParentescos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Par_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbParentescos entity)
        {
            const String commandText = "PR_tbParentescos_Insert";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Par_Descripcion", DbType = DbType.String, Value = entity.Par_Descripcion},
            new SqlParameter(){ParameterName= "@Par_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Par_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Edit(tbParentescos entity)
        {
            const String commandText = "PR_tbParentescos_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Par_Id", DbType = DbType.Int32, Value = entity.Par_Id},
            new SqlParameter(){ParameterName= "@Par_Descripcion", DbType = DbType.String, Value = entity.Par_Descripcion},
            new SqlParameter(){ParameterName= "@Par_UsuarioModifica", DbType = DbType.Int32, Value = entity.Par_UsuarioModifica}
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbParentescos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Par_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
