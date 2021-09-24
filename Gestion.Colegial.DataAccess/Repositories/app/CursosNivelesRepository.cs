using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Complements;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class CursosNivelesRepository : Interfaces.IRepositories<tbCursosNiveles>
    {
        public DataTable List(string sear)
        {
            const string commandText = "PR_tbCursosNiveles_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbCursosNiveles_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cun_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbCursosNiveles_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Cun_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }
        public bool Add(tbCursosNiveles entity)
        {
            throw new NotImplementedException();
        }

        public bool Edit(tbCursosNiveles entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int identifier)
        {
            const String commandText = "PR_tbCursosNiveles_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "Cun_Id", DbType = DbType.Int32, Value = identifier},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }
    }
}
