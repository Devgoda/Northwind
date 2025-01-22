using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Northwind.DAL.Repositories;

namespace Northwind.API
{
    public class Customers(INorthwindDBRepo northwindDBRepo)
    {
        private readonly INorthwindDBRepo _northwindDBRepo = northwindDBRepo;

        [Function("Customers")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            return new OkObjectResult(await _northwindDBRepo.GetCustomersAsync());

        }
    }
}
