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
            DataTable result = await Read(sear, commandText, sqlParameters);
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
                new SqlParameter(){ParameterName= "@Emp_Codigo", DbType = DbType.String, Value = entity.Emp_Codigo },
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = entity.Tit_Id },
                new SqlParameter(){ParameterName= "@Car_Id", DbType = DbType.Int32, Value = entity.Car_Id },
                new SqlParameter(){ParameterName= "@Per_Identidad", DbType = DbType.String, Value = entity.Per.Per_Identidad },
                new SqlParameter(){ParameterName= "@Per_PrimerNombre", DbType = DbType.String, Value = entity.Per.Per_PrimerNombre },
                new SqlParameter(){ParameterName= "@Per_SegundoNombre", DbType = DbType.String, Value = entity.Per.Per_SegundoNombre },
                new SqlParameter(){ParameterName= "@Per_ApellidoPaterno", DbType = DbType.String, Value = entity.Per.Per_ApellidoPaterno },
                new SqlParameter(){ParameterName= "@Per_ApellidoMaterno", DbType = DbType.String, Value = entity.Per.Per_ApellidoMaterno },
                new SqlParameter(){ParameterName= "@Per_FechaNacimiento", DbType = DbType.DateTime, Value = entity.Per.Per_FechaNacimiento },
                new SqlParameter(){ParameterName= "@Per_CorreoElectronico", DbType = DbType.String, Value = entity.Per.Per_CorreoElectronico },
                new SqlParameter(){ParameterName= "@Per_Telefono", DbType = DbType.String, Value = entity.Per.Per_Telefono },
                new SqlParameter(){ParameterName= "@Per_Direccion", DbType = DbType.String, Value = entity.Per.Per_Direccion },
                new SqlParameter(){ParameterName= "@Per_Sexo", DbType = DbType.String, Value = entity.Per.Per_Sexo },
                new SqlParameter(){ParameterName= "@Per_UsuarioRegistra", DbType = DbType.Int32, Value = entity.Per.Per_UsuarioRegistra }
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbEmpleados entity)
        {
            const String commandText = "PR_tbEmpleados_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Emp_Id", DbType = DbType.Int32, Value = entity.Emp_Id },
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entity.Per.Per_Id },
                new SqlParameter(){ParameterName= "@Emp_Codigo", DbType = DbType.String, Value = entity.Emp_Codigo },
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = entity.Tit_Id },
                new SqlParameter(){ParameterName= "@Car_Id", DbType = DbType.Int32, Value = entity.Car_Id },
                new SqlParameter(){ParameterName= "@Per_Identidad", DbType = DbType.String, Value = entity.Per.Per_Identidad },
                new SqlParameter(){ParameterName= "@Per_PrimerNombre", DbType = DbType.String, Value = entity.Per.Per_PrimerNombre },
                new SqlParameter(){ParameterName= "@Per_SegundoNombre", DbType = DbType.String, Value = entity.Per.Per_SegundoNombre },
                new SqlParameter(){ParameterName= "@Per_ApellidoPaterno", DbType = DbType.String, Value = entity.Per.Per_ApellidoPaterno },
                new SqlParameter(){ParameterName= "@Per_ApellidoMaterno", DbType = DbType.String, Value = entity.Per.Per_ApellidoMaterno },
                new SqlParameter(){ParameterName= "@Per_FechaNacimiento", DbType = DbType.DateTime, Value = entity.Per.Per_FechaNacimiento },
                new SqlParameter(){ParameterName= "@Per_CorreoElectronico", DbType = DbType.String, Value = entity.Per.Per_CorreoElectronico },
                new SqlParameter(){ParameterName= "@Per_Telefono", DbType = DbType.String, Value = entity.Per.Per_Telefono },
                new SqlParameter(){ParameterName= "@Per_Direccion", DbType = DbType.String, Value = entity.Per.Per_Direccion },
                new SqlParameter(){ParameterName= "@Per_EsActivo", DbType = DbType.Boolean, Value = entity.Per.Per_EsActivo },
                new SqlParameter(){ParameterName= "@Per_Sexo", DbType = DbType.String, Value = entity.Per.Per_Sexo },
                new SqlParameter(){ParameterName= "@Per_UsuarioModifica", DbType = DbType.Int32, Value = entity.Per.Per_UsuarioModifica }

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
