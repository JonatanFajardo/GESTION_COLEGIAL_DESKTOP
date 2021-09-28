using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.DataAccess.Repositories.bitacoras;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion.Colegial.DataAccess.Complements
{
    public static class DbApp
    {
        public static DataTable List(string buscar, string commandText, dynamic parameters)
        {
            Answer answer = new Answer();
            try
            {
                DataTable table = new DataTable();
                SqlDataReader reader;
                using (SqlConnection conn = new SqlConnection(Connection.Sql()))
                {
                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@numberPagina", entidad.numberPagina);
                        //cmd.Parameters.AddWithValue("@amount", entidad.amount);
                        //cmd.Parameters.AddWithValue("@search", entidad.search);
                        conn.Open();
                        reader = cmd.ExecuteReader();
                        table.Load(reader);
                        reader.Close();
                        if (table == null)
                        {
                            return null;
                        }
                        return table;
                    };
                }
            }
            catch (Exception error)
            {
                answer.Incidents(error);
                ErrorLogRepository.Add(error);
                return null;
            }
        }

        public static DataTable List(string commandText, dynamic parameters)
        {
            Answer answer = new Answer();
            try
            {
                DataTable table = new DataTable();
                SqlDataReader reader;
                using (SqlConnection conn = new SqlConnection(Connection.Sql()))
                {
                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        //cmd.Parameters.AddWithValue("@numberPagina", entidad.numberPagina);
                        //cmd.Parameters.AddWithValue("@amount", entidad.amount);
                        //cmd.Parameters.AddWithValue("@search", entidad.search);
                        conn.Open();
                        reader = cmd.ExecuteReader();
                        table.Load(reader);
                        reader.Close();
                        if (table == null)
                        {
                            return null;
                        }
                        return table;
                    };
                }
            }
            catch (Exception error)
            {
                answer.Incidents(error);
                ErrorLogRepository.Add(error);
                return null;
            }
        }


        public static Boolean Insert(string commandText, dynamic parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.Sql()))
                {
                    using (SqlCommand command = new SqlCommand(commandText, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);

                        con.Open();
                        int result = command.ExecuteNonQuery();
                        if (result < 1)
                        {
                            //answer.Message = "Ninguna fila Registrada";
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception error)
            {
                //Answer answer = new Answer();
                //answer.Incidents(error);
                ErrorLogRepository.Add(error);
                return true;
            }
        }

        public static Boolean Update(string commandText, dynamic parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.Sql()))
                {
                    using (SqlCommand command = new SqlCommand(commandText, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);

                        con.Open();
                        int result = command.ExecuteNonQuery();
                        if (result < 1)
                        {
                            //answer.Message = "Ninguna fila Registrada";
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception error)
            {
                Answer answer = new Answer();
                answer.Incidents(error);
                ErrorLogRepository.Add(error);
                return true;
            }
        }

        public static DataTable Find(string buscar, string commandText, dynamic parameters)
        {
            throw new NotImplementedException();
        }

        public static DataTable Detail(string buscar, string commandText, dynamic parameters)
        {
            throw new NotImplementedException();
        }

    }
}