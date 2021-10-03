using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class NotasRepository : Interfaces.IRepositories<tbNotas>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbNotas_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbNotas_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Not_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbNotas_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Not_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbNotas entidad)
        {
            const String commandText = "PR_tbNotas_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Not_Nota", DbType = DbType.Int32, Value = entidad.Not_Nota},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entidad.Mat_Id},
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = entidad.Sem_Id},
                new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = entidad.Pac_Id},
                new SqlParameter(){ParameterName= "@Not_Año", DbType = DbType.Date, Value = entidad.Not_Año},
                new SqlParameter(){ParameterName= "@Not_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Not_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbNotas entidad)
        {
            const String commandText = "PR_tbNotas_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Not_Id", DbType = DbType.Int32, Value = entidad.Not_Id},
                new SqlParameter(){ParameterName= "@Not_Nota", DbType = DbType.Int32, Value = entidad.Not_Nota},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entidad.Mat_Id},
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = entidad.Sem_Id},
                new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = entidad.Pac_Id},
                new SqlParameter(){ParameterName= "@Not_Año", DbType = DbType.Date, Value = entidad.Not_Año},
                new SqlParameter(){ParameterName= "@Not_EsActivo", DbType = DbType.String, Value = entidad.Not_EsActivo},
                new SqlParameter(){ParameterName= "@Not_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Not_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbNotas_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Not_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
