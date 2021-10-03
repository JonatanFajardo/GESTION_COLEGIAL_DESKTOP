﻿using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class SeccionesRepository : Interfaces.IRepositories<tbSecciones>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbSecciones_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = await DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string identifier)
        {
            const string commandText = "PR_tbSecciones_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sec_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(string identifier)
        {
            const string commandText = "PR_tbSecciones_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Sec_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbSecciones entidad)
        {
            const String commandText = "PR_tbSecciones_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sec_Descripcion", DbType = DbType.String, Value = entidad.Sec_Descripcion},
                new SqlParameter(){ParameterName= "@Sec_UsuarioRegistra", DbType = DbType.Int32  , Value = entidad.Sec_UsuarioRegistra}
            };
            Boolean result = await DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbSecciones entidad)
        {
            const String commandText = "PR_tbSecciones_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = entidad.Sec_Id},
                new SqlParameter(){ParameterName= "@Sec_Descripcion", DbType = DbType.String, Value = entidad.Sec_Descripcion},
                new SqlParameter(){ParameterName= "@Sec_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Sec_UsuarioModifica},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbSecciones_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Sec_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
