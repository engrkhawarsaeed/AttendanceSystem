using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class GenericRepository : IGenericRepository
    {
        public SqlConnection connection;
        //private IGenericRepository _genericRepository;

        ////Constructor
        //public GenericRepository(IGenericRepository genericRepository)
        //{
        //    _genericRepository = genericRepository;
        //}
        

        //insert update delete
        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            connection =new SqlConnection("Server=KHAWAR-SAEED;Database=TestDB;Trusted_Connection=True;"); //Connection
            connection.Open(); //Connection Open
            SqlCommand command = new SqlCommand(query,connection); //Command
            command.CommandType = System.Data.CommandType.StoredProcedure; //Command type
            command.Parameters.AddRange(parameters);
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public SqlDataReader ExecuteReader(string query)
        {
            connection = new SqlConnection("Server=KHAWAR-SAEED;Database=TestDB;Trusted_Connection=True;"); //Connection
            connection.Open(); //Connection Open
            SqlCommand command = new SqlCommand(query, connection); //Command
            command.CommandType = System.Data.CommandType.StoredProcedure; //Command type
            var result = command.ExecuteReader();
            connection.Close();
            return result;
        }

        public DataSet ExecuteAdapter(string query)
        {
            connection = new SqlConnection("Server=KHAWAR-SAEED;Database=TestDB;Trusted_Connection=True;"); //Connection
            connection.Open(); //Connection Open
            SqlDataAdapter command = new SqlDataAdapter(query, connection); //Command
            DataSet dataSet = new DataSet();
            command.Fill(dataSet);
            return dataSet;
        }
    }
}
