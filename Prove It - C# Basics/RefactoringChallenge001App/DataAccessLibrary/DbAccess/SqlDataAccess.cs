using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLibrary.DbAccess
{
    public class SqlDataAccess
    {
        private string _connectionString;

        public SqlDataAccess()
        {
            _connectionString =  ConfigurationManager.ConnectionStrings["DapperDemoDB"].ConnectionString;
        }

        public IEnumerable<T> LoadData<T, U>(
            string storedProcedure,
            U parameters)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void SaveData<T>(
            string storedProcedure,
            T parameters)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
