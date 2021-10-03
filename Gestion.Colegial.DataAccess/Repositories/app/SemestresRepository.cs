using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class SemestresRepository : Interfaces.IRepositories<tbSemestres>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbSemestres_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbSemestres_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sem_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbSemestres_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sem_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbSemestres entidad)
        {
            const String commandText = "PR_tbSemestres_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sem_Descripcion", DbType = DbType.String, Value = entidad.Sem_Descripcion},
                new SqlParameter(){ParameterName= "@Sem_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Sem_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbSemestres entidad)
        {
            const String commandText = "PR_tbSemestres_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = entidad.Sem_Id},
                new SqlParameter(){ParameterName= "@Sem_Descripcion", DbType = DbType.String, Value = entidad.Sem_Descripcion},
                new SqlParameter(){ParameterName= "@Sem_EsActivo", DbType = DbType.String, Value = entidad.Sem_EsActivo},
                new SqlParameter(){ParameterName= "@Sem_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Sem_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbSemestres_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
