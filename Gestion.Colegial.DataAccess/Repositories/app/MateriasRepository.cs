using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class MateriasRepository : Interfaces.IRepositories<tbMaterias>
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

        public Boolean Add(tbMaterias entidad)
        {
            const String commandText = "PR_tbMaterias_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entidad.Mat_Id},
                new SqlParameter(){ParameterName= "@Mat_Nombre", DbType = DbType.String, Value = entidad.Mat_Nombre},
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entidad.Dur_Id},
                new SqlParameter(){ParameterName= "@EsActivo", DbType = DbType.String, Value = entidad.EsActivo},
                new SqlParameter(){ParameterName= "@Mat_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Mat_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }
        public Boolean Edit(tbMaterias entidad)
        {
            const String commandText = "PR_tbMaterias_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entidad.Mat_Id},
                new SqlParameter(){ParameterName= "@Mat_Nombre", DbType = DbType.String, Value = entidad.Mat_Nombre},
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entidad.Dur_Id},
                new SqlParameter(){ParameterName= "@EsActivo", DbType = DbType.String, Value = entidad.EsActivo},
                new SqlParameter(){ParameterName= "@Mat_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Mat_UsuarioModifica},
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
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
