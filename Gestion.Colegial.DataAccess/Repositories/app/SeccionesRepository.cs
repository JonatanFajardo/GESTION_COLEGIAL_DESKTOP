using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class SeccionesRepository : BaseRepository, Interfaces.IRepositories<tbSecciones>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbSecciones_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Read(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbSecciones_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sec_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbSecciones_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sec_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbSecciones entity)
        {
            const String commandText = "PR_tbSecciones_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sec_Descripcion", DbType = DbType.String, Value = entity.Sec_Descripcion},
                new SqlParameter(){ParameterName= "@Sec_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Sec_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbSecciones entity)
        {
            const String commandText = "PR_tbSecciones_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entity.Sec_Id},
                new SqlParameter(){ParameterName= "@Sec_Descripcion", DbType = DbType.String, Value = entity.Sec_Descripcion},
                new SqlParameter(){ParameterName= "@Sec_UsuarioModifica", DbType = DbType.Int32, Value = entity.Sec_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbSecciones_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
