﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TodoLibrary.DataAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionStringName)
    {
        string connectionString = _config.GetConnectionString(connectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);

        var rows = await connection.QueryAsync<T>(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);

        return rows.ToList();
    }

    public Task SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectionStringName)
    {
        string connectionString = _config.GetConnectionString(connectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);

        return connection.ExecuteAsync(
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure);
    }
}
