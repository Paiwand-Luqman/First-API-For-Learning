using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstAPI.Data;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;



    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }
    public async Task<IEnumerable<T>> select_all<T, U>(string StoredProcedure, U Parameters)
    {
        using (IDbConnection db = new SqlConnection(_config.GetConnectionString("connection")))
        {
            return (await db.QueryAsync<T>(StoredProcedure, Parameters, commandType: CommandType.StoredProcedure));
        }
    }
    public async Task<IEnumerable<T>> GetGrid<T, U>(string StoredProcedure, U Parameters)
    {
        using (IDbConnection db = new SqlConnection(_config.GetConnectionString("connection")))
        {
            return (await db.QueryAsync<T>(StoredProcedure, Parameters, commandType: CommandType.StoredProcedure));
        }
    }
    public async Task<T> Get<T, U>(string StoredProcedure, U Parameters)
    {
        using (IDbConnection db = new SqlConnection(_config.GetConnectionString("connection")))
        {
            return (await db.QueryAsync<T>(StoredProcedure, Parameters, commandType: CommandType.StoredProcedure)).FirstOrDefault();
        }
    }
    public async Task<T> Update<T, U>(string StoredProcedure, U Parameters)
    {
        using (IDbConnection db = new SqlConnection(_config.GetConnectionString("connection")))
        {
            return (await db.QueryAsync<T>(StoredProcedure, Parameters, commandType: CommandType.StoredProcedure)).FirstOrDefault();
        }
    }
    public async Task<IEnumerable<T>> GetAutoComplete<T, U>(string StoredProcedure, U Parameters)
    {
        using (IDbConnection db = new SqlConnection(_config.GetConnectionString("connection")))
        {
            return (await db.QueryAsync<T>(StoredProcedure, Parameters, commandType: CommandType.StoredProcedure));
        }
    }
    public async Task<T> InsertUser<T, U>(string StoredProcedure, U Parameters)
    {
        using (IDbConnection db = new SqlConnection(_config.GetConnectionString("connection")))
        {
            return (await db.QueryAsync<T>(StoredProcedure, Parameters, commandType: CommandType.StoredProcedure)).First();
        }
    }

}