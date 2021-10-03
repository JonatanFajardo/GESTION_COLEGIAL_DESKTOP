using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class CargosRepository : Interfaces.IRepositories<tbCargos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbCargos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbCargos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Car_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbCargos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Car_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbCargos entidad)
        {
            const String commandText = "PR_tbCargos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Car_Descripcion", DbType = DbType.String, Value = entidad.Car_Descripcion},
                new SqlParameter(){ParameterName= "@Car_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Car_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbCargos entidad)
        {
            const String commandText = "PR_tbCargos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Car_Id", DbType = DbType.Int32, Value = entidad.Car_Id},
                new SqlParameter(){ParameterName= "@Car_Descripcion", DbType = DbType.String, Value = entidad.Car_Descripcion},
                new SqlParameter(){ParameterName= "@Car_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Car_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbCargos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "Car_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
