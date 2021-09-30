using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class SemestresRepository : Interfaces.IRepositories<tbSemestres>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbSemestres_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbSemestres_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sem_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbSemestres_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sem_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbSemestres entidad)
        {
            const String commandText = "PR_tbSemestres_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sem_Descripcion", DbType = DbType.String, Value = entidad.Sem_Descripcion},
                new SqlParameter(){ParameterName= "@Sem_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Sem_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbSemestres entidad)
        {
            const String commandText = "PR_tbSemestres_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = entidad.Sem_Id},
                new SqlParameter(){ParameterName= "@Sem_Descripcion", DbType = DbType.String, Value = entidad.Sem_Descripcion},
                new SqlParameter(){ParameterName= "@Sem_EsActivo", DbType = DbType.String, Value = entidad.Sem_EsActivo},
                new SqlParameter(){ParameterName= "@Sem_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Sem_UsuarioModifica},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbSemestres_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
