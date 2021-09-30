using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class DiasRepository : Interfaces.IRepositories<tbDias>
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
                new SqlParameter() { ParameterName = "@Dia_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbDias_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Dia_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public Boolean Add(tbDias entidad)
        {
            const String commandText = "PR_tbDias_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Descripcion", DbType = DbType.String, Value = entidad.Dia_Descripcion},
                new SqlParameter(){ParameterName= "@Dia_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Dia_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbDias entidad)
        {
            const String commandText = "PR_tbDias_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entidad.Dia_Id},
                new SqlParameter(){ParameterName= "@Dia_Descripcion", DbType = DbType.String, Value = entidad.Dia_Descripcion},
                new SqlParameter(){ParameterName= "@Dia_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Dia_UsuarioModifica},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbDias_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
