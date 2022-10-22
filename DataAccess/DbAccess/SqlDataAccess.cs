using System.Data;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration config;

        public SqlDataAccess(IConfiguration config)
        {
            this.config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string StoredProcedure,
            U parameters,
            string ConnectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(config.GetConnectionString(ConnectionId));

            return await connection.QueryAsync<T>(StoredProcedure, parameters,
                commandType: CommandType.StoredProcedure);


        }

        public async Task SaveData<T>(
            string StoredProcedure,
            T Parameters,
            string ConnectionId = "Default")
        {

            using IDbConnection connection = new SqlConnection(config.GetConnectionString(ConnectionId));

            await connection.ExecuteAsync(StoredProcedure, Parameters,
                commandType: CommandType.StoredProcedure);


        }
    }
}
