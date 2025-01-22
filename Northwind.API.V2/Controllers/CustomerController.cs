using Microsoft.AspNetCore.Mvc;
using Northwind.DAL.Repositories;
using Northwind.Domain.Entities;

namespace Northwind.API.V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController(INorthwindDBRepo northwindDBRepo, ILogger<CustomerController> logger) : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger = logger;
        private readonly INorthwindDBRepo _northwindDBRepo = northwindDBRepo;

        [HttpGet(Name = "Customer")]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _northwindDBRepo.GetCustomersAsync();

        }
    }
}
