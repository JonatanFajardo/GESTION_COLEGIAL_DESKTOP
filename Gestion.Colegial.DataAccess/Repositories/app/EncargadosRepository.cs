﻿using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class EncargadosRepository : Interfaces.IRepositories<tbEncargados>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbEncargados_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbEncargados_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Enc_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbEncargados_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Enc_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbEncargados entidad)
        {
            const String commandText = "PR_tbEncargados_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entidad.Per_Id},
                new SqlParameter(){ParameterName= "@Enc_Ocupacion", DbType = DbType.String, Value = entidad.Enc_Ocupacion}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbEncargados entidad)
        {
            const String commandText = "PR_tbEncargados_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Enc_Id", DbType = DbType.Int32, Value = entidad.Enc_Id},
                new SqlParameter(){ParameterName= "@Per_Id", DbType = DbType.Int32, Value = entidad.Per_Id},
                new SqlParameter(){ParameterName= "@Enc_Ocupacion", DbType = DbType.String, Value = entidad.Enc_Ocupacion},
                new SqlParameter(){ParameterName= "@Enc_EsActivo", DbType = DbType.String, Value = entidad.Enc_EsActivo}
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbEncargados_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Enc_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
