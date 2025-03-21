﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Gestion.Colegial.DataAccess.Repositories.app
{
    public class BaseRepository
    {
        protected static async Task<DataTable> Select(string buscar, string commandText, dynamic parameters)
        {
            DataTable table = new DataTable();
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(Connection.Sql))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@numberPagina", entity.numberPagina);
                    //cmd.Parameters.AddWithValue("@amount", entity.amount);
                    //cmd.Parameters.AddWithValue("@search", entity.search);
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

        protected static async Task<DataTable> Select(string commandText, dynamic parameters)
        {
            DataTable table = new DataTable();
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(Connection.Sql))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    //cmd.Parameters.AddWithValue("@numberPagina", entity.numberPagina);
                    //cmd.Parameters.AddWithValue("@amount", entity.amount);
                    //cmd.Parameters.AddWithValue("@search", entity.search);
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


        protected static async Task<Boolean> Insert(string commandText, dynamic parameters)
        {
            using (SqlConnection con = new SqlConnection(Connection.Sql))
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

        protected static async Task<Boolean> Update(string commandText, dynamic parameters)
        {
            using (SqlConnection con = new SqlConnection(Connection.Sql))
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
            //}
            //catch (Exception error)
            //{
            //    Answer answer = new Answer();
            //    answer.Incidents(error);
            //    ErrorLogRepository.Incidents(error);
            //    return true;
            //}
        }

        protected static async Task<DataTable> Search(int identifier, string commandText, dynamic parameters)
        {
            DataTable table = new DataTable();
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(Connection.Sql))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    //cmd.Parameters.AddWithValue("@numberPagina", entity.numberPagina);
                    //cmd.Parameters.AddWithValue("@amount", entity.amount);
                    //cmd.Parameters.AddWithValue("@search", entity.search);
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

        protected static async Task<DataTable> Search(string value, string commandText, dynamic parameters)
        {
            throw new NotImplementedException();
        }

        protected static async Task<DataTable> Details(int buscar, string commandText, dynamic parameters)
        {
            throw new NotImplementedException();
        }

    }
}
