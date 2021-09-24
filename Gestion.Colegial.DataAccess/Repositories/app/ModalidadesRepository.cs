using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Complements;
using Gestion.Colegial.DataAccess.Repositories.bitacoras;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ModalidadesRepository : Interfaces.IRepositories<tbModalidades>
    {
        //====================================================//
        //                    INSTANCIACION
        //====================================================//
        //private Conexion conexion = new Conexion();
        private SqlDataReader reader;
        private DataTable table;
        //private SqlCommand cmd;

        //====================================================//
        //                      METODOS   
        //====================================================//

        //public static Boolean Select(string commandText, dynamic parameters)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(Connection.Sql()))
        //        {
        //            using (SqlCommand command = new SqlCommand(commandText, con))
        //            {
        //                command.CommandType = CommandType.StoredProcedure;
        //                command.Parameters.AddRange(parameters);

        //                int result = command.ExecuteNonQuery();
        //                con.Open();
        //                if (result < 1)
        //                {
        //                    //answer.Message = "Ninguna fila Registrada";
        //                    return true;
        //                }
        //                return false;
        //            }
        //        }
        //    }
        //    catch (Exception error)
        //    {
        //        Answer answer = new Answer();
        //        answer.Incidents(error);
        //        ErrorLogRepository.Add(answer);
        //        return true;
        //    }
        //}

        public DataTable List(string sear)
        {
            const string commandText = "PR_tbModalidades_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear", DbType = DbType.String, Value = sear },
            };
            DataTable result = DbApp.List(sear, commandText, sqlParameters);
            return result;
        }

        public DataTable Find(string identifier)
        {
            const string commandText = "PR_tbModalidades_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear1", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Find(identifier, commandText, sqlParameters);
            return result;
        }

        public DataTable Detail(string identifier)
        {
            const string commandText = "PR_tbModalidades_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@sear1", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = DbApp.Detail(identifier, commandText, sqlParameters);
            return result;
        }

        public Boolean Add(tbModalidades entidad)
        {
            entidad.Mda_UsuarioRegistra = 1;
            const string commandText = "PR_tbModalidades_Insert";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Mda_Descripcion", DbType = DbType.String, Value = entidad.Mda_Descripcion },
            new SqlParameter(){ParameterName= "@Mda_UsuarioRegistra", DbType = DbType.Int32, Value = entidad.Mda_UsuarioRegistra }
            };
            Boolean result = DbApp.Insert(commandText, sqlParameters);
            return result;
        }

        public Boolean Edit(tbModalidades entidad)
        {
            entidad.Mda_UsuarioModifica = 1;
            const string commandText = "PR_tbModalidades_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entidad.Mda_Id },
                new SqlParameter(){ParameterName= "@Mda_Descripcion", DbType = DbType.String, Value = entidad.Mda_Descripcion },
                new SqlParameter(){ParameterName= "@Mda_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Mda_UsuarioModifica }
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

        public Boolean Remove(int delete)
        {
            const String commandText = "PR_tbModalidades_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = delete},
            };
            Boolean result = DbApp.Update(commandText, sqlParameters);
            return result;
        }

    }
}
