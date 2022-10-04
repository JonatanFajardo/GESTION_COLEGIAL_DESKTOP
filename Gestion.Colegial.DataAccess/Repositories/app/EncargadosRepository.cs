using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class EncargadosRepository : BaseRepository, Interfaces.IRepositories<tbEncargados>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbEncargados_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbEncargados_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Enc_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbEncargados_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Enc_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbEncargados entity)
        {
            const String commandText = "PR_tbEncargados_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Enc_Ocupacion", DbType = DbType.String, Value = entity.Enc_Ocupacion },
                new SqlParameter(){ParameterName= "@Per_Identidad", DbType = DbType.String, Value = entity.Per_Identidad },
                new SqlParameter(){ParameterName= "@Per_PrimerNombre", DbType = DbType.String, Value = entity.Per_PrimerNombre },
                new SqlParameter(){ParameterName= "@Per_SegundoNombre", DbType = DbType.String, Value = entity.Per_SegundoNombre },
                new SqlParameter(){ParameterName= "@Per_ApellidoPaterno", DbType = DbType.String, Value = entity.Per_ApellidoPaterno },
                new SqlParameter(){ParameterName= "@Per_ApellidoMaterno", DbType = DbType.String, Value = entity.Per_ApellidoMaterno },
                new SqlParameter(){ParameterName= "@Per_FechaNacimiento", DbType = DbType.Date, Value = entity.Per_FechaNacimiento },
                new SqlParameter(){ParameterName= "@Per_CorreoElectronico", DbType = DbType.String, Value = entity.Per_CorreoElectronico },
                new SqlParameter(){ParameterName= "@Per_Telefono", DbType = DbType.String, Value = entity.Per_Telefono },
                new SqlParameter(){ParameterName= "@Per_Direccion", DbType = DbType.String, Value = entity.Per_Direccion },
                new SqlParameter(){ParameterName= "@Per_Sexo", DbType = DbType.String, Value = entity.Per_Sexo },
                new SqlParameter(){ParameterName= "@Per_UsuarioRegistra", DbType = DbType.Int32, Value = entity.Per_UsuarioRegistra }
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbEncargados entity)
        {
            const String commandText = "PR_tbEncargados_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Enc_Id", DbType = DbType.Int32, Value = entity.Enc_Id },
                new SqlParameter(){ParameterName= "@Enc_Ocupacion", DbType = DbType.String, Value = entity.Enc_Ocupacion },
                new SqlParameter(){ParameterName= "@Per_Identidad", DbType = DbType.String, Value = entity.Per_Identidad },
                new SqlParameter(){ParameterName= "@Per_PrimerNombre", DbType = DbType.String, Value = entity.Per_PrimerNombre },
                new SqlParameter(){ParameterName= "@Per_SegundoNombre", DbType = DbType.String, Value = entity.Per_SegundoNombre },
                new SqlParameter(){ParameterName= "@Per_ApellidoPaterno", DbType = DbType.String, Value = entity.Per_ApellidoPaterno },
                new SqlParameter(){ParameterName= "@Per_ApellidoMaterno", DbType = DbType.String, Value = entity.Per_ApellidoMaterno },
                new SqlParameter(){ParameterName= "@Per_FechaNacimiento", DbType = DbType.DateTime, Value = entity.Per_FechaNacimiento },
                new SqlParameter(){ParameterName= "@Per_CorreoElectronico", DbType = DbType.String, Value = entity.Per_CorreoElectronico },
                new SqlParameter(){ParameterName= "@Per_Telefono", DbType = DbType.String, Value = entity.Per_Telefono },
                new SqlParameter(){ParameterName= "@Per_Direccion", DbType = DbType.String, Value = entity.Per_Direccion },
                new SqlParameter(){ParameterName= "@Per_EsActivo", DbType = DbType.Boolean, Value = entity.Per_EsActivo },
                new SqlParameter(){ParameterName= "@Per_Sexo", DbType = DbType.String, Value = entity.Per_Sexo },
                new SqlParameter(){ParameterName= "@Per_UsuarioModifica", DbType = DbType.Int32, Value = entity.Per_UsuarioModifica }
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbEncargados_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Enc_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}