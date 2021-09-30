using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class HorasRepository : Interfaces.IRepositories<tbHoras>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbHoras_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbHoras_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Hor_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbHoras_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Hor_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public Boolean Add(tbHoras entidad)
        {
            const String commandText = "PR_tbHoras_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Hor_Hora", DbType = DbType.String , Value = entidad.Hor_Hora},
                new SqlParameter(){ParameterName= "@Hor_UsuarioRegistra", DbType = DbType.Int32 , Value = entidad.Hor_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }


        public Boolean Edit(tbHoras entidad)
        {
            const String commandText = "PR_tbHoras_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Hor_Id", DbType = DbType.Int32, Value = entidad.Hor_Id},
                new SqlParameter(){ParameterName= "@Hor_Hora", DbType = DbType.String , Value = entidad.Hor_Hora},
                new SqlParameter(){ParameterName= "@Hor_UsuarioModifica", DbType = DbType.Int32 , Value = entidad.Hor_UsuarioModifica},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbHoras_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Hor_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
