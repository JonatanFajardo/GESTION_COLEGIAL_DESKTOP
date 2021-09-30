using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class NivelesEducativosRepository : Interfaces.IRepositories<tbNivelesEducativos>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbNivelesEducativos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbNivelesEducativos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Niv_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbNivelesEducativos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Niv_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbNivelesEducativos entidad)
        {
            const String commandText = "PR_tbNivelesEducativos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Niv_Descripcion", DbType = DbType.String, Value = entidad.Niv_Descripcion},
                new SqlParameter(){ParameterName= "@Niv_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Niv_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbNivelesEducativos entidad)
        {
            const String commandText = "PR_tbNivelesEducativos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entidad.Niv_Id},
                new SqlParameter(){ParameterName= "@Niv_Descripcion", DbType = DbType.String, Value = entidad.Niv_Descripcion},
                new SqlParameter(){ParameterName= "@EsActivo", DbType = DbType.String, Value = entidad.Niv_EsActivo},
                new SqlParameter(){ParameterName= "@Niv_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Niv_UsuarioModifica},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbNivelesEducativos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
