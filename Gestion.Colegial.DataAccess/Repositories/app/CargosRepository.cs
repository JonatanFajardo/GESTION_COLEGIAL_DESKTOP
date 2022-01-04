using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class CargosRepository : BaseRepository, Interfaces.IRepositories<tbCargos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbCargos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string value)
        {
            const string commandText = "PR_tbCargos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Car_Id", DbType = DbType.Int32, Value = value },
            };
            DataTable result = await Search(value, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbCargos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Car_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbCargos entidad)
        {
            const String commandText = "PR_tbCargos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Car_Descripcion", DbType = DbType.String, Value = entidad.Car_Descripcion},
                new SqlParameter(){ParameterName= "@Car_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Car_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
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
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbCargos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "Car_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
