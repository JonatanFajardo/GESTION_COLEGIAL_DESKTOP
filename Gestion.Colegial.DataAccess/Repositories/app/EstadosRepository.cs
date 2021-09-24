using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class EstadosRepository : Interfaces.IRepositories<tbEstados>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbEstados_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbEstados_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Est_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbEstados_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Est_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbEstados entidad)
        {
            const String commandText = "PR_tbEstados_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Est_Id", DbType = DbType.Int32, Value = entidad.Est_Id},
                new SqlParameter(){ParameterName= "@Est_Descripcion", DbType = DbType.String, Value = entidad.Est_Descripcion},
                new SqlParameter(){ParameterName= "@Est_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Est_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbEstados entidad)
        {
            const String commandText = "PR_tbEstados_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Est_Id", DbType = DbType.Int32, Value = entidad.Est_Id},
            new SqlParameter(){ParameterName= "@Est_Descripcion", DbType = DbType.String, Value = entidad.Est_Descripcion},
            new SqlParameter(){ParameterName= "@Est_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Est_UsuarioModifica},
        };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbEstados_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Est_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
