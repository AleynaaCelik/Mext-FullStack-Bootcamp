using CustomerAppPrewiew.Domain.Dtos;
using CustomerAppPrewiew.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppPrewiew.Domain.Abstractions
{
    public interface ICustomerService
    {
        //customerin sahip olmasıgereken nitelikler
        List<CustomerListDto> List();
        void Add(AddCustomerDto addCustomerDto);
    }
}
