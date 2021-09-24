using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class HorarioProfesoresRepository : Interfaces.IRepositories<tbHorarioProfesores>
    {
        public Boolean Add(tbHorarioProfesores entidad)
        {
            const String commandText = "PR_tbHorarioProfesores_Insert";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@HoPr_Id", DbType = DbType.Int32, Value = entidad.HoPr_Id},
            new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
            new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entidad.Cun_Id},
            new SqlParameter(){ParameterName= "@HoPr_HoraInicio", DbType = DbType.Int32, Value = entidad.HoPr_HoraInicio},
            new SqlParameter(){ParameterName= "@HoPr_HoraFinaliza", DbType = DbType.Int32, Value = entidad.HoPr_HoraFinaliza},
            new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entidad.Dia_Id},
            new SqlParameter(){ParameterName= "@HoPr_UsuarioRegistra", DbType = DbType.Int32 , Value = entidad.HoPr_UsuarioRegistra},
        };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }


        public Boolean Edit(tbHorarioProfesores entidad)
        {
            const String commandText = "PR_tbHorarioProfesores_Update";
            SqlParameter[] sqlParameters = {
    new SqlParameter(){ParameterName= "@HoPr_Id", DbType = DbType.Int32, Value = entidad.HoPr_Id},
    new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
    new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entidad.Cun_Id},
    new SqlParameter(){ParameterName= "@HoPr_HoraInicio", DbType = DbType.Int32, Value = entidad.HoPr_HoraInicio},
    new SqlParameter(){ParameterName= "@HoPr_HoraFinaliza", DbType = DbType.Int32, Value = entidad.HoPr_HoraFinaliza},
    new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entidad.Dia_Id},
    new SqlParameter(){ParameterName= "@HoPr_UsuarioModifica", DbType = DbType.Int32 , Value = entidad.HoPr_UsuarioModifica},

  };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public DataTable List(string sear)
        {
            const string commandText = "PR_tbHorarioProfesores_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbHorarioProfesores_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear1", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbHorarioProfesores_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear1", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbHorarioProfesores_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@sear1", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
