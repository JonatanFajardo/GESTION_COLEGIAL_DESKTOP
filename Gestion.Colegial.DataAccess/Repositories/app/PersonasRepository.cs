﻿using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class PersonasRepository : Interfaces.IRepositories<tbPersonas>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbPersonas_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbPersonas_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Per_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbPersonas_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Per_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbPersonas entidad)
        {
            const String commandText = "PR_tbPersonas_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Per_Identidad", DbType = DbType.String, Value = entidad.Per_Identidad},
                new SqlParameter(){ParameterName= "@Per_PrimerNombre", DbType = DbType.String, Value = entidad.Per_PrimerNombre},
                new SqlParameter(){ParameterName= "@Per_SegundoNombre", DbType = DbType.String, Value = entidad.Per_SegundoNombre},
                new SqlParameter(){ParameterName= "@Per_ApellidoPaterno", DbType = DbType.String, Value = entidad.Per_ApellidoPaterno},
                new SqlParameter(){ParameterName= "@Per_ApellidoMaterno", DbType = DbType.String, Value = entidad.Per_ApellidoMaterno},
                new SqlParameter(){ParameterName= "@Per_FechaNacimiento", DbType = DbType.Date, Value = entidad.Per_FechaNacimiento},
                new SqlParameter(){ParameterName= "@Per_CorreoElectronico", DbType = DbType.String, Value = entidad.Per_CorreoElectronico},
                new SqlParameter(){ParameterName= "@Per_Telefono", DbType = DbType.String, Value = entidad.Per_Telefono},
                new SqlParameter(){ParameterName= "@Per_Direccion", DbType = DbType.String, Value = entidad.Per_Direccion},
                new SqlParameter(){ParameterName= "@Per_Sexo", DbType = DbType.String, Value = entidad.Per_Sexo},
                new SqlParameter(){ParameterName= "@Per_UsuarioRegistro", DbType = DbType.Int32 , Value = entidad.Per_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbPersonas entidad)
        {
            const String commandText = "PR_tbPersonas_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entidad.Per_Id},
                new SqlParameter(){ParameterName= "@Per_Identidad", DbType = DbType.String, Value = entidad.Per_Identidad},
                new SqlParameter(){ParameterName= "@Per_PrimerNombre", DbType = DbType.String, Value = entidad.Per_PrimerNombre},
                new SqlParameter(){ParameterName= "@Per_SegundoNombre", DbType = DbType.String, Value = entidad.Per_SegundoNombre},
                new SqlParameter(){ParameterName= "@Per_ApellidoPaterno", DbType = DbType.String, Value = entidad.Per_ApellidoPaterno},
                new SqlParameter(){ParameterName= "@Per_ApellidoMaterno", DbType = DbType.String, Value = entidad.Per_ApellidoMaterno},
                new SqlParameter(){ParameterName= "@Per_FechaNacimiento", DbType = DbType.Date, Value = entidad.Per_FechaNacimiento},
                new SqlParameter(){ParameterName= "@Per_CorreoElectronico", DbType = DbType.String, Value = entidad.Per_CorreoElectronico},
                new SqlParameter(){ParameterName= "@Per_Telefono", DbType = DbType.String, Value = entidad.Per_Telefono},
                new SqlParameter(){ParameterName= "@Per_Direccion", DbType = DbType.String, Value = entidad.Per_Direccion},
                new SqlParameter(){ParameterName= "@Per_Sexo", DbType = DbType.String, Value = entidad.Per_Sexo},
                new SqlParameter(){ParameterName= "@Per_EsActivo", DbType = DbType.String, Value = entidad.Per_EsActivo},
                new SqlParameter(){ParameterName= "@Per_UsuarioModifica", DbType = DbType.Int32 , Value = entidad.Per_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }        

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbPersonas_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
