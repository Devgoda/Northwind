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
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {
            //var idFilter = req.Query["CustomerID"];
            //var companyNameFilter = req.Query["CompanyName"];

            return new OkObjectResult(await _northwindDBRepo.GetCustomersAsync());

        }
    }
}
