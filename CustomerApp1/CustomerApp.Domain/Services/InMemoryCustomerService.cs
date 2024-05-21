using CustomerApp.Domain.Abstractions;
using CustomerApp.Domain.Dtos;
using CustomerApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        static List<Customer> customers = new();

        public void Create(CustomerCreateDto customerCreateDto)
        {
            Customer customer = new Customer()
            {
                Id =Guid.NewGuid(),
                Name=Customer
            };
        }

        public List<CustomerListDto> List()
        {
            throw new NotImplementedException();
        }
    }
}
