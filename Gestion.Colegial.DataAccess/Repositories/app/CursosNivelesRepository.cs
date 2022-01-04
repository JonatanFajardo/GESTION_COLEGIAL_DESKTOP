using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class CursosNivelesRepository : BaseRepository, Interfaces.IRepositories<tbCursosNiveles>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbCursosNiveles_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string value)
        {
            const string commandText = "PR_tbCursosNiveles_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cun_Id", DbType = DbType.Int32, Value = value },
            };
            DataTable result = await Search(value, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbCursosNiveles_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cun_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbCursosNiveles entidad)
        {
            const String commandText = "PR_tbCursosNiveles_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cun_Descripcion", DbType = DbType.String, Value = entidad.Cun_Descripcion},
                new SqlParameter(){ParameterName= "@Cun_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Cun_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbCursosNiveles entidad)
        {
            const String commandText = "PR_tbCursosNiveles_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entidad.Cun_Id},
                new SqlParameter(){ParameterName= "@Cun_Descripcion", DbType = DbType.String, Value = entidad.Cun_Descripcion},
                new SqlParameter(){ParameterName= "@Cun_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Cun_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbCursosNiveles_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "Cun_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
