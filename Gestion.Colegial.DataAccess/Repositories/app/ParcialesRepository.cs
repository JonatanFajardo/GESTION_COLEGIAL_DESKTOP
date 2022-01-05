using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ParcialesRepository : BaseRepository, Interfaces.IRepositories<tbParciales>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbParciales_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbParciales_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Pac_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbParciales_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Pac_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbParciales entity)
        {
            const String commandText = "PR_tbParciales_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Pac_Descripcion", DbType = DbType.String, Value = entity.Pac_Descripcion},
                new SqlParameter(){ParameterName= "@Pac_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Pac_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbParciales entity)
        {
            const String commandText = "PR_tbParciales_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = entity.Pac_Id},
            new SqlParameter(){ParameterName= "@Pac_Descripcion", DbType = DbType.String, Value = entity.Pac_Descripcion},
            new SqlParameter(){ParameterName= "@Pac_UsuarioModifica", DbType = DbType.Int32, Value = entity.Pac_UsuarioModifica},
        };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbParciales_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
