using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class HorarioAlumnosRepository : BaseRepository, Interfaces.IRepositories<tbHorarioAlumnos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbHorarioAlumnos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Read(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbHorarioAlumnos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@HoAl_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbHorarioAlumnos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@HoAl_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbHorarioAlumnos entity)
        {
            const String commandText = "PR_tbHorarioAlumnos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entity.Cur_Id},
                new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entity.Cun_Id},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entity.Mat_Id},
                new SqlParameter(){ParameterName= "@HoAl_HoraInicio", DbType = DbType.Int32, Value = entity.HoAl_HoraInicio},
                new SqlParameter(){ParameterName= "@HoAl_HoraFinaliza", DbType = DbType.Int32, Value = entity.HoAl_HoraFinaliza},
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entity.Dia_Id},
                new SqlParameter(){ParameterName= "@HoAl_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.HoAl_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbHorarioAlumnos entity)
        {
            const String commandText = "PR_tbHorarioAlumnos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@HoAl_Id", DbType = DbType.Int32, Value = entity.HoAl_Id},
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entity.Cur_Id},
                new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entity.Cun_Id},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entity.Mat_Id},
                new SqlParameter(){ParameterName= "@HoAl_HoraInicio", DbType = DbType.Int32, Value = entity.HoAl_HoraInicio},
                new SqlParameter(){ParameterName= "@HoAl_HoraFinaliza", DbType = DbType.Int32, Value = entity.HoAl_HoraFinaliza},
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entity.Dia_Id},
                new SqlParameter(){ParameterName= "@HoAl_UsuarioModifica", DbType = DbType.Int32, Value = entity.HoAl_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbHorarioAlumnos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@HoAl_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
