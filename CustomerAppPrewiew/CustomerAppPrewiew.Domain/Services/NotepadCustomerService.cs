using CustomerAppPrewiew.Domain.Abstractions;
using CustomerAppPrewiew.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppPrewiew.Domain.Services
{
    public class NotepadCustomerService : ICustomerService
    {
        private readonly string _dbpath ;
        public NotepadCustomerService()
        {
            _dbpath= "C:\\Users\\DELL\\source\\repos\\CustomerAppPrewiew\\CustomerAppPrewiew.API\\TextDb.txt";
        }
        public void Add(AddCustomerDto addCustomerDto)
        {
            
            string data=$"{Guid.NewGuid()},{addCustomerDto.PhoneNumber},{addCustomerDto.Surname},{addCustomerDto.Name}";
            File.AppendAllText(_dbpath,data);
        }
        
        public List<CustomerListDto> List()
        {
            List<CustomerListDto> customerList = new();
            string rawData=File.ReadAllText(_dbpath);
            string[]lines=rawData.Split("\r\n");
            foreach (string line in lines)
            {
                string[] data = line.Split(",");
                var customerListDto = new CustomerListDto()
                {
                    Id = Guid.Parse(data[0]),
                    Surname = data[2],
                    Name = data[3],

                };
                customerList.Add(customerListDto);
            }
            return customerList;
        }
    }
}
