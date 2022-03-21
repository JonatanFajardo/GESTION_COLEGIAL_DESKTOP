using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class NivelesEducativosRepository : BaseRepository, Interfaces.IRepositories<tbNivelesEducativos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbNivelesEducativos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Read(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbNivelesEducativos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Niv_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbNivelesEducativos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Niv_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbNivelesEducativos entity)
        {
            const String commandText = "PR_tbNivelesEducativos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Niv_Descripcion", DbType = DbType.String, Value = entity.Niv_Descripcion},
                new SqlParameter(){ParameterName= "@Niv_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Niv_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbNivelesEducativos entity)
        {
            const String commandText = "PR_tbNivelesEducativos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entity.Niv_Id},
                new SqlParameter(){ParameterName= "@Niv_Descripcion", DbType = DbType.String, Value = entity.Niv_Descripcion},
                new SqlParameter(){ParameterName= "@EsActivo", DbType = DbType.String, Value = entity.Niv_EsActivo},
                new SqlParameter(){ParameterName= "@Niv_UsuarioModifica", DbType = DbType.Int32, Value = entity.Niv_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbNivelesEducativos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
