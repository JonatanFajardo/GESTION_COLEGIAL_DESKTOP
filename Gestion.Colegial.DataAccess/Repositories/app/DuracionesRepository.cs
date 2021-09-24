using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class DuracionesRepository : Interfaces.IRepositories<tbDuraciones>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbDias_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbDias_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbDias_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public Boolean Add(tbDuraciones entidad)
        {
            const String commandText = "PR_tbDuraciones_Insert";
            SqlParameter[] sqlParameters = {
        new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entidad.Dur_Id},
        new SqlParameter(){ParameterName= "@Dur_Descripcion", DbType = DbType.String, Value = entidad.Dur_Descripcion},
        new SqlParameter(){ParameterName= "@Dur_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Dur_UsuarioRegistra}
};
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbDuraciones entidad)
        {
            const String commandText = "PR_tbDuraciones_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entidad.Dur_Id},
                new SqlParameter(){ParameterName= "@Dur_Descripcion", DbType = DbType.String, Value = entidad.Dur_Descripcion},
                new SqlParameter(){ParameterName= "@Dur_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Dur_UsuarioModifica},
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbDias_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
