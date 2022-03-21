using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class HorarioProfesoresRepository : BaseRepository, Interfaces.IRepositories<tbHorarioProfesores>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbHorarioProfesores_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Read(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbHorarioProfesores_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear1", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbHorarioProfesores_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear1", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbHorarioProfesores entity)
        {
            const String commandText = "PR_tbHorarioProfesores_Insert";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entity.Cur_Id},
            new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entity.Cun_Id},
            new SqlParameter(){ParameterName= "@HoPr_HoraInicio", DbType = DbType.Int32, Value = entity.HoPr_HoraInicio},
            new SqlParameter(){ParameterName= "@HoPr_HoraFinaliza", DbType = DbType.Int32, Value = entity.HoPr_HoraFinaliza},
            new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entity.Dia_Id},
            new SqlParameter(){ParameterName= "@HoPr_UsuarioRegistra", DbType = DbType.Int32 , Value = entity.HoPr_UsuarioRegistra},
        };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }


        public async Task<Boolean> Edit(tbHorarioProfesores entity)
        {
            const String commandText = "PR_tbHorarioProfesores_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@HoPr_Id", DbType = DbType.Int32, Value = entity.HoPr_Id},
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entity.Cur_Id},
                new SqlParameter(){ParameterName= "@Cun_Id", DbType = DbType.Int32, Value = entity.Cun_Id},
                new SqlParameter(){ParameterName= "@HoPr_HoraInicio", DbType = DbType.Int32, Value = entity.HoPr_HoraInicio},
                new SqlParameter(){ParameterName= "@HoPr_HoraFinaliza", DbType = DbType.Int32, Value = entity.HoPr_HoraFinaliza},
                new SqlParameter(){ParameterName= "@Dia_Id", DbType = DbType.Int32, Value = entity.Dia_Id},
                new SqlParameter(){ParameterName= "@HoPr_UsuarioModifica", DbType = DbType.Int32 , Value = entity.HoPr_UsuarioModifica},
                };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }


        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbHorarioProfesores_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@sear1", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
