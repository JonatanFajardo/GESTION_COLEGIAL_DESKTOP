﻿using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class NotasRepository : BaseRepository, Interfaces.IRepositories<tbNotas>
    {
        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbNotas_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> ListOne(int identifier)
        {
            const string commandText = "PR_tbNotas_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Not_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Search(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbNotas_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Not_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }
        public async Task<Boolean> Add(tbNotas entity)
        {
            const String commandText = "PR_tbNotas_Insert";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Not_Nota", DbType = DbType.Int32, Value = entity.Not_Nota},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entity.Mat_Id},
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = entity.Sem_Id},
                new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = entity.Pac_Id},
                new SqlParameter(){ParameterName= "@Not_Año", DbType = DbType.Date, Value = entity.Not_Año},
                new SqlParameter(){ParameterName= "@Not_UsuarioRegistra", DbType = DbType.Int32  , Value = entity.Not_UsuarioRegistra}
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbNotas entity)
        {
            const String commandText = "PR_tbNotas_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Not_Id", DbType = DbType.Int32, Value = entity.Not_Id},
                new SqlParameter(){ParameterName= "@Not_Nota", DbType = DbType.Int32, Value = entity.Not_Nota},
                new SqlParameter(){ParameterName= "@Mat_Id", DbType = DbType.Int32, Value = entity.Mat_Id},
                new SqlParameter(){ParameterName= "@Sem_Id", DbType = DbType.Int32, Value = entity.Sem_Id},
                new SqlParameter(){ParameterName= "@Pac_Id", DbType = DbType.Int32, Value = entity.Pac_Id},
                new SqlParameter(){ParameterName= "@Not_Año", DbType = DbType.Date, Value = entity.Not_Año},
                new SqlParameter(){ParameterName= "@Not_EsActivo", DbType = DbType.String, Value = entity.Not_EsActivo},
                new SqlParameter(){ParameterName= "@Not_UsuarioModifica", DbType = DbType.Int32, Value = entity.Not_UsuarioModifica},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int identifier)
        {
            const String commandText = "PR_tbNotas_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Not_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }
    }
}
