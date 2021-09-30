using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ParcialesRepository : Interfaces.IRepositories<tbParciales>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbParciales_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbParciales_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Pac_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbParciales_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Pac_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbParciales entidad)
        {
            const String commandText = "PR_tbParciales_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Pac_Descripcion", DbType = DbType.String, Value = entidad.Pac_Descripcion},
                new SqlParameter(){ParameterName= "@Pac_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Pac_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbParciales entidad)
        {
            const String commandText = "PR_tbParciales_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = entidad.Pac_Id},
            new SqlParameter(){ParameterName= "@Pac_Descripcion", DbType = DbType.String, Value = entidad.Pac_Descripcion},
            new SqlParameter(){ParameterName= "@Pac_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Pac_UsuarioModifica},
        };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbParciales_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
