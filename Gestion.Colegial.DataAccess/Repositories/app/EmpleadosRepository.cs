using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class EmpleadosRepository : Interfaces.IRepositories<tbEmpleados>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbEmpleados_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbEmpleados_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Emp_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbEmpleados_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Emp_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbEmpleados entidad)
        {
            const String commandText = "PR_tbEmpleados_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Emp_Codigo", DbType = DbType.String, Value = entidad.Emp_Codigo},
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entidad.Per_Id},
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = entidad.Tit_Id},
                new SqlParameter(){ParameterName= "@Car_Id", DbType = DbType.Int32, Value = entidad.Car_Id}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbEmpleados entidad)
        {
            const String commandText = "PR_tbEmpleados_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Emp_Id", DbType = DbType.Int32, Value = entidad.Emp_Id},
                new SqlParameter(){ParameterName= "@Emp_Codigo", DbType = DbType.String, Value = entidad.Emp_Codigo},
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entidad.Per_Id},
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = entidad.Tit_Id},
                new SqlParameter(){ParameterName= "@Car_Id", DbType = DbType.Int32, Value = entidad.Car_Id},
                new SqlParameter(){ParameterName= "@Emp_EsActivo", DbType = DbType.String , Value = entidad.Emp_EsActivo},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbEmpleados_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Emp_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
