using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Repositories
{
    public interface INorthwindDBRepo
    {
        public Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
