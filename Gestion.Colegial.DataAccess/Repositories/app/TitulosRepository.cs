using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class TitulosRepository : Interfaces.IRepositories<tbTitulos>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbTitulos_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbTitulos_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Tit_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbTitulos_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Tit_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbTitulos entidad)
        {
            const String commandText = "PR_tbTitulos_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Tit_Descripcion", DbType = DbType.String, Value = entidad.Tit_Descripcion},
                new SqlParameter(){ParameterName= "@Tit_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Tit_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbTitulos entidad)
        {
            const String commandText = "PR_tbTitulos_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = entidad.Tit_Id},
                new SqlParameter(){ParameterName= "@Tit_Descripcion", DbType = DbType.String, Value = entidad.Tit_Descripcion},
                new SqlParameter(){ParameterName= "@Tit_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Tit_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbTitulos_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Tit_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
