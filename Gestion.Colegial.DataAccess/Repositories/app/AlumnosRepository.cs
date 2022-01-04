using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class AlumnosRepository : BaseRepository, Interfaces.IRepositories<tbAlumnos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbAlumnos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string value)
        {
            const string commandText = "PR_tbAlumnos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Alu_Id", DbType = DbType.Int32, Value = value },
            };
            DataTable result = await Search(value, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbAlumnos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Alu_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbAlumnos entidad)
        {
            const String commandText = "PR_tbAlumnos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entidad.Per_Id},
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
                new SqlParameter(){ParameterName= "@Est_Id", DbType = DbType.Int32, Value = entidad.Est_Id},
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbAlumnos entidad)
        {
            const String commandText = "PR_tbAlumnos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Alu_Id", DbType = DbType.Int32, Value = entidad.Alu_Id},
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entidad.Per_Id},
                new SqlParameter(){ParameterName= "@Cur_Id", DbType = DbType.Int32, Value = entidad.Cur_Id},
                new SqlParameter(){ParameterName= "@Est_Id", DbType = DbType.Int32, Value = entidad.Est_Id},
                new SqlParameter(){ParameterName= "@Alu_EsActivo", DbType = DbType.String , Value = entidad.Alu_EsActivo},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbAlumnos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Alu_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
