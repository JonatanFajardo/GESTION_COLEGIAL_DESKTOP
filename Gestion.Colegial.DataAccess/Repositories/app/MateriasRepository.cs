using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class MateriasRepository : Interfaces.IRepositories<tbMaterias>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbMaterias_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbMaterias_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Mat_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbMaterias_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Mat_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbMaterias entidad)
        {
            const String commandText = "PR_tbMaterias_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Nombre", DbType = DbType.String, Value = entidad.Mat_Nombre},
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entidad.Dur_Id},
                new SqlParameter(){ParameterName= "@Mat_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Mat_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Edit(tbMaterias entidad)
        {
            const String commandText = "PR_tbMaterias_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entidad.Mat_Id},
                new SqlParameter(){ParameterName= "@Mat_Nombre", DbType = DbType.String, Value = entidad.Mat_Nombre},
                new SqlParameter(){ParameterName= "@Dur_Id", DbType = DbType.Int32, Value = entidad.Dur_Id},
                new SqlParameter(){ParameterName= "@EsActivo", DbType = DbType.String, Value = entidad.EsActivo},
                new SqlParameter(){ParameterName= "@Mat_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Mat_UsuarioModifica},
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbMaterias_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
