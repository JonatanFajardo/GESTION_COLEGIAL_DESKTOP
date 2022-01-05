using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class CursosRepository : BaseRepository, Interfaces.IRepositories<tbCursos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbCursos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbCursos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbCursos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbCursos entity)
        {
            const String commandText = "PR_tbCursos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = entity.Cno_Id},
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entity.Aul_Id},
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entity.Sec_Id},
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entity.Niv_Id},
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entity.Mda_Id},
                new SqlParameter(){ParameterName= "@Cur_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Cur_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbCursos entity)
        {
            const String commandText = "PR_tbCursos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entity.Cur_Id},
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = entity.Cno_Id},
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entity.Aul_Id},
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entity.Sec_Id},
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entity.Niv_Id},
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entity.Mda_Id},
                new SqlParameter(){ParameterName= "@Cur_EsActivo", DbType = DbType.String, Value = entity.Cur_EsActivo},
                new SqlParameter(){ParameterName= "@Cur_UsuarioModifica", DbType = DbType.Int32, Value = entity.Cur_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbCursos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
