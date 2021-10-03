using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class AlumnosRepository : Interfaces.IRepositories<tbAlumnos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbAlumnos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbAlumnos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Alu_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbAlumnos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Alu_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
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
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
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
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbAlumnos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Alu_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
