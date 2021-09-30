using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class AulasRepository : Interfaces.IRepositories<tbAulas>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbAulas_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbAulas_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Aul_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbAulas_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Aul_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbAulas entidad)
        {
            const String commandText = "PR_tbAulas_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Descripcion", DbType = DbType.String, Value = entidad.Aul_Descripcion},
                new SqlParameter(){ParameterName= "@Aul_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Aul_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbAulas entidad)
        {
            const String commandText = "PR_tbAulas_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entidad.Aul_Id},
                new SqlParameter(){ParameterName= "@Aul_Descripcion", DbType = DbType.String, Value = entidad.Aul_Descripcion},
                new SqlParameter(){ParameterName= "@Aul_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Aul_UsuarioModifica},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }        

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbAulas_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
