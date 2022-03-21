using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class DuracionesRepository : BaseRepository, Interfaces.IRepositories<tbDuraciones>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbDuraciones_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Read(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbDuraciones_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbDuraciones_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbDuraciones entity)
        {
            const String commandText = "PR_tbDuraciones_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dur_Descripcion", DbType = DbType.String, Value = entity.Dur_Descripcion},
                new SqlParameter(){ParameterName= "@Dur_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Dur_UsuarioRegistra}
};
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbDuraciones entity)
        {
            const String commandText = "PR_tbDuraciones_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entity.Dur_Id},
                new SqlParameter(){ParameterName= "@Dur_Descripcion", DbType = DbType.String, Value = entity.Dur_Descripcion},
                new SqlParameter(){ParameterName= "@Dur_UsuarioModifica", DbType = DbType.Int32, Value = entity.Dur_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbDias_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
