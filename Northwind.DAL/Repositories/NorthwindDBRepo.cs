using Northwind.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Northwind.DAL.Repositories
{
    public class NorthwindDBRepo(IConfiguration configuration) : INorthwindDBRepo
    {
        private string _connectionString = configuration["NorthwindDB"];

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var sql = "spGetCustomers";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var result = (await connection.QueryAsync<Customer>(sql, commandType: System.Data.CommandType.StoredProcedure));
                        await connection.CloseAsync();

                        return new List<Customer>();
                    }
                }

            };
        }
    }
}
