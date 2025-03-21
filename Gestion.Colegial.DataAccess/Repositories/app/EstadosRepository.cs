﻿using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class EstadosRepository : BaseRepository, Interfaces.IRepositories<tbEstados>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbEstados_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbEstados_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Est_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbEstados_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Est_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbEstados entity)
        {
            const String commandText = "PR_tbEstados_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Est_Descripcion", DbType = DbType.String, Value = entity.Est_Descripcion},
                new SqlParameter(){ParameterName= "@Est_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Est_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbEstados entity)
        {
            const String commandText = "PR_tbEstados_Update";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Est_Id", DbType = DbType.Int32, Value = entity.Est_Id},
            new SqlParameter(){ParameterName= "@Est_Descripcion", DbType = DbType.String, Value = entity.Est_Descripcion},
            new SqlParameter(){ParameterName= "@Est_UsuarioModifica", DbType = DbType.Int32, Value = entity.Est_UsuarioModifica},
        };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbEstados_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Est_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
