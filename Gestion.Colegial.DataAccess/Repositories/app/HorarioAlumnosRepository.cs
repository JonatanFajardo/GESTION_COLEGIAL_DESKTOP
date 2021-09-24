using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class HorarioAlumnosRepository : Interfaces.IRepositories<tbHorarioAlumnos>
    {
        public Boolean Add(tbHorarioAlumnos entidad)
        {
            const String commandText = "PR_tbHorarioAlumnos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@HoAl_Id", DbType = DbType.Int32, Value = entidad.HoAl_Id},
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
                new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entidad.Cun_Id},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entidad.Mat_Id},
                new SqlParameter(){ParameterName= "@HoAl_HoraInicio", DbType = DbType.Int32, Value = entidad.HoAl_HoraInicio},
                new SqlParameter(){ParameterName= "@HoAl_HoraFinaliza", DbType = DbType.Int32, Value = entidad.HoAl_HoraFinaliza},
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entidad.Dia_Id},
                new SqlParameter(){ParameterName= "@HoAl_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.HoAl_UsuarioRegistra}
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbHorarioAlumnos entidad)
        {
            const String commandText = "PR_tbHorarioAlumnos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@HoAl_Id", DbType = DbType.Int32, Value = entidad.HoAl_Id},
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
                new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entidad.Cun_Id},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entidad.Mat_Id},
                new SqlParameter(){ParameterName= "@HoAl_HoraInicio", DbType = DbType.Int32, Value = entidad.HoAl_HoraInicio},
                new SqlParameter(){ParameterName= "@HoAl_HoraFinaliza", DbType = DbType.Int32, Value = entidad.HoAl_HoraFinaliza},
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entidad.Dia_Id},
                new SqlParameter(){ParameterName= "@HoAl_UsuarioModifica", DbType = DbType.Int32, Value = entidad.HoAl_UsuarioModifica},
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public DataTable List(string sear)
        {
            const string commandText = "PR_tbHorarioAlumnos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbHorarioAlumnos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@HoAl_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbHorarioAlumnos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@HoAl_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbHorarioAlumnos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@HoAl_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
