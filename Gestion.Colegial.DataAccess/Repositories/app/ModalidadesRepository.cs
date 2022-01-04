using Gestion.Colegial.Commons.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class ModalidadesRepository : BaseRepository, Interfaces.IRepositories<tbModalidades>
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

        public async Task<DataTable> List(string sear)
        {
            const string commandText = "PR_tbModalidades_List";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Search", DbType = DbType.String, Value = sear },
            };
            DataTable result = await Select(sear, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Find(string value)
        {
            const string commandText = "PR_tbModalidades_Find";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Mda_Id", DbType = DbType.Int32, Value = value },
            };
            DataTable result = await Search(value, commandText, sqlParameters);
            return result;
        }

        public async Task<DataTable> Detail(int identifier)
        {
            const string commandText = "PR_tbModalidades_Detail";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Mda_Id", DbType = DbType.Int32, Value = identifier },
            };
            DataTable result = await Details(identifier, commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Add(tbModalidades entidad)
        {
            //entidad.Mda_UsuarioRegistra = 1;
            const string commandText = "PR_tbModalidades_Insert";
            SqlParameter[] sqlParameters = {
            new SqlParameter(){ParameterName= "@Mda_Descripcion", DbType = DbType.String, Value = entidad.Mda_Descripcion },
            new SqlParameter(){ParameterName= "@Mda_UsuarioRegistra", DbType = DbType.Int32, Value = entidad.Mda_UsuarioRegistra }
            };
            Boolean result = await Insert(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Edit(tbModalidades entidad)
        {
            entidad.Mda_UsuarioModifica = 1;
            const string commandText = "PR_tbModalidades_Update";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = entidad.Mda_Id },
                new SqlParameter(){ParameterName= "@Mda_Descripcion", DbType = DbType.String, Value = entidad.Mda_Descripcion },
                new SqlParameter(){ParameterName= "@Mda_UsuarioModifica", DbType = DbType.Int32, Value = entidad.Mda_UsuarioModifica }
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

        public async Task<Boolean> Remove(int delete)
        {
            const String commandText = "PR_tbModalidades_Delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter(){ParameterName= "@Mda_Id", DbType = DbType.Int32, Value = delete},
            };
            Boolean result = await Update(commandText, sqlParameters);
            return result;
        }

    }
}
