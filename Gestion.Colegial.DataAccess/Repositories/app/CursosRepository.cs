using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class CursosRepository : Interfaces.IRepositories<tbCursos>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbCursos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbCursos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbCursos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cur_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbCursos entidad)
        {
            const String commandText = "PR_tbCursos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = entidad.Cno_Id},
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entidad.Aul_Id},
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entidad.Sec_Id},
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entidad.Niv_Id},
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entidad.Mda_Id},
                new SqlParameter(){ParameterName= "@Cur_EsActivo", DbType = DbType.String, Value = entidad.Cur_EsActivo},
                new SqlParameter(){ParameterName= "@Cur_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Cur_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbCursos entidad)
        {
            const String commandText = "PR_tbCursos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
                new SqlParameter(){ParameterName= "@Cno_Id", DbType = DbType.Int32, Value = entidad.Cno_Id},
                new SqlParameter(){ParameterName= "@Aul_Id", DbType = DbType.Int32, Value = entidad.Aul_Id},
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entidad.Sec_Id},
                new SqlParameter(){ParameterName= "@Niv_Id", DbType = DbType.Int32, Value = entidad.Niv_Id},
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entidad.Mda_Id},
                new SqlParameter(){ParameterName= "@Cur_EsActivo", DbType = DbType.String, Value = entidad.Cur_EsActivo},
                new SqlParameter(){ParameterName= "@Cur_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Cur_UsuarioModifica},
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbCursos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
