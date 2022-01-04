using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class CursosNombresRepository : BaseRepository, Interfaces.IRepositories<tbCursosNombres>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbCursosNombres_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string value)
        {
            const string commandText = "PR_tbCursosNombres_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cno_Id", DbType = DbType.Int32, Value = value },
            };
            DataTable result = await Search(value, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbCursosNombres_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cno_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbCursosNombres entidad)
        {
            const String commandText = "PR_tbCursosNombres_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cno_Descripcion", DbType = DbType.String, Value = entidad.Cno_Descripcion},
                new SqlParameter(){ParameterName= "@Cno_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Cno_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbCursosNombres entidad)
        {
            const String commandText = "PR_tbCursosNombres_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = entidad.Cno_Id},
                new SqlParameter(){ParameterName= "@Cno_Descripcion", DbType = DbType.String, Value = entidad.Cno_Descripcion},
                new SqlParameter(){ParameterName= "@Cno_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Cno_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbCursosNombres_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
