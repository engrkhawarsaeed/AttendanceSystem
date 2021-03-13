using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public interface IGenericRepository
    {
        public int ExecuteNonQuery(string query, SqlParameter[] parameters);
        public SqlDataReader ExecuteReader(string query);
        public DataSet ExecuteAdapter(string query);
    }
}
