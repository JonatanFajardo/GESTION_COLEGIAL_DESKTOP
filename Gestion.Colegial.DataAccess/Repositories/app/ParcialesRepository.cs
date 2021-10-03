using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ParcialesRepository : Interfaces.IRepositories<tbParciales>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbParciales_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbParciales_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Pac_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbParciales_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Pac_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbParciales entidad)
        {
            const String commandText = "PR_tbParciales_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Pac_Descripcion", DbType = DbType.String, Value = entidad.Pac_Descripcion},
                new SqlParameter(){ParameterName= "@Pac_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Pac_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbParciales entidad)
        {
            const String commandText = "PR_tbParciales_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = entidad.Pac_Id},
            new SqlParameter(){ParameterName= "@Pac_Descripcion", DbType = DbType.String, Value = entidad.Pac_Descripcion},
            new SqlParameter(){ParameterName= "@Pac_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Pac_UsuarioModifica},
        };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbParciales_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
