using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class EmpleadosRepository : BaseRepository, Interfaces.IRepositories<tbEmpleados>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbEmpleados_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbEmpleados_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Emp_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbEmpleados_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Emp_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbEmpleados entity)
        {
            const String commandText = "PR_tbEmpleados_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Emp_Codigo", DbType = DbType.String, Value = entity.Emp_Codigo},
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entity.Per_Id},
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = entity.Tit_Id},
                new SqlParameter(){ParameterName= "@Car_Id", DbType = DbType.Int32, Value = entity.Car_Id}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbEmpleados entity)
        {
            const String commandText = "PR_tbEmpleados_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Emp_Id", DbType = DbType.Int32, Value = entity.Emp_Id},
                new SqlParameter(){ParameterName= "@Emp_Codigo", DbType = DbType.String, Value = entity.Emp_Codigo},
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entity.Per_Id},
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = entity.Tit_Id},
                new SqlParameter(){ParameterName= "@Car_Id", DbType = DbType.Int32, Value = entity.Car_Id},
                new SqlParameter(){ParameterName= "@Emp_EsActivo", DbType = DbType.String , Value = entity.Emp_EsActivo},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbEmpleados_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Emp_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
