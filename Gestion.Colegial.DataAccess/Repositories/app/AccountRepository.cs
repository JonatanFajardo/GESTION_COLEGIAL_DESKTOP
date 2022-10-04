using Gestion.Colegial.Commons.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class AccountRepository : BaseRepository
    {
        public async Task<DataTable> Autentication(tbUsuarios entity)
        {
            const string commandText = "PR_tbUsuarios_Autentication_Segurity";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Usu_Name", DbType = DbType.String, Value = entity.Usu_Name },
                new SqlParameter() { ParameterName = "@Usu_Contraseña", DbType = DbType.String, Value = entity.Usu_Contraseña },
            };
            DataTable result = await Select(commandText, sqlParameters);
            return result;
            //DataTable table = new DataTable();
            //SqlDataReader reader;
            //using (SqlConnection conn = new SqlConnection(Connection.Sql()))
            //{
            //    using (SqlCommand command = new SqlCommand(commandText, conn))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddRange(sqlParameters);
            //        conn.Open();
            //        reader = command.ExecuteReader();
            //        table.Load(reader);
            //        reader.Close();
            //        if (table == null)
            //        {
            //            //return -1;
            //        }
            //        return table;
            //    }

            //    //return result;
            //}
        }

        public async Task<DataTable> List(tbUsuarios entity)
        {
            const string commandText = "PR_tbUsuarios_List_Segurity";
            SqlParameter[] sqlParameters = {
                new SqlParameter() { ParameterName = "@Usu_Name", DbType = DbType.String, Value = entity.Usu_Name },
                new SqlParameter() { ParameterName = "@Usu_Contraseña", DbType = DbType.String, Value = entity.Usu_Contraseña },
            };
            DataTable result = await Select(commandText, sqlParameters);
            return result;
        }
    }
}