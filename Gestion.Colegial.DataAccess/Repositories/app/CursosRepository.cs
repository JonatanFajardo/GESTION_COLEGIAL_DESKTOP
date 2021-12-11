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
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbCursos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbCursos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbCursos entidad)
        {
            const String commandText = "PR_tbCursos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = entidad.Cno_Id},
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entidad.Aul_Id},
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entidad.Sec_Id},
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entidad.Niv_Id},
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entidad.Mda_Id},
                new SqlParameter(){ParameterName= "@Cur_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Cur_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbCursos entidad)
        {
            const String commandText = "PR_tbCursos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = entidad.Cno_Id},
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entidad.Aul_Id},
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entidad.Sec_Id},
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entidad.Niv_Id},
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entidad.Mda_Id},
                new SqlParameter(){ParameterName= "@Cur_EsActivo", DbType = DbType.String, Value = entidad.Cur_EsActivo},
                new SqlParameter(){ParameterName= "@Cur_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Cur_UsuarioModifica},
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
