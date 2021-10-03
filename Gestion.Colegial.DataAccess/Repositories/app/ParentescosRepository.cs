using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ParentescosRepository : Interfaces.IRepositories<tbParentescos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbParentescos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbParentescos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Par_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbParentescos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Par_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbParentescos entidad)
        {
            const String commandText = "PR_tbParentescos_Insert";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Par_Descripcion", DbType = DbType.String, Value = entidad.Par_Descripcion},
            new SqlParameter(){ParameterName= "@Par_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Par_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Edit(tbParentescos entidad)
        {
            const String commandText = "PR_tbParentescos_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Par_Id", DbType = DbType.Int32, Value = entidad.Par_Id},
            new SqlParameter(){ParameterName= "@Par_Descripcion", DbType = DbType.String, Value = entidad.Par_Descripcion},
            new SqlParameter(){ParameterName= "@Par_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Par_UsuarioModifica}
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbParentescos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Par_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
