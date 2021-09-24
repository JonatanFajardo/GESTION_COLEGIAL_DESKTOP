using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ParentescosRepository : Interfaces.IRepositories<tbParentescos>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbParentescos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbParentescos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Par_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbParentescos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Par_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbParentescos entidad)
        {
            const String commandText = "PR_tbParentescos_Insert";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Par_Descripcion", DbType = DbType.String, Value = entidad.Par_Descripcion},
            new SqlParameter(){ParameterName= "@Par_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Par_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }
        public Boolean Edit(tbParentescos entidad)
        {
            const String commandText = "PR_tbParentescos_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Par_Id", DbType = DbType.Int32, Value = entidad.Par_Id},
            new SqlParameter(){ParameterName= "@Par_Descripcion", DbType = DbType.String, Value = entidad.Par_Descripcion},
            new SqlParameter(){ParameterName= "@Par_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Par_UsuarioModifica}
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbParentescos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Par_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
