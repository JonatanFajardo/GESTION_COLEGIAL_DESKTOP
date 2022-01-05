using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class MateriasRepository : BaseRepository, Interfaces.IRepositories<tbMaterias>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbMaterias_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbMaterias_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Mat_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbMaterias_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Mat_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbMaterias entity)
        {
            const String commandText = "PR_tbMaterias_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Nombre", DbType = DbType.String, Value = entity.Mat_Nombre},
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entity.Dur_Id},
                new SqlParameter(){ParameterName= "@Mat_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Mat_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Edit(tbMaterias entity)
        {
            const String commandText = "PR_tbMaterias_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entity.Mat_Id},
                new SqlParameter(){ParameterName= "@Mat_Nombre", DbType = DbType.String, Value = entity.Mat_Nombre},
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entity.Dur_Id},
                new SqlParameter(){ParameterName= "@EsActivo", DbType = DbType.String, Value = entity.EsActivo},
                new SqlParameter(){ParameterName= "@Mat_UsuarioModifica", DbType = DbType.Int32, Value = entity.Mat_UsuarioModifica},
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbMaterias_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
