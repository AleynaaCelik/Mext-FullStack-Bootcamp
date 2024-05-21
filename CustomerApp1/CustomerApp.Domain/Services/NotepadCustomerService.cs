using CustomerApp.Domain.Abstractions;
using CustomerApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public class NotepadCustomerService : ICustomerService
    {
        public void Create(CustomerCreateDto customerCreateDto)
        {
            string saveData=$"{Guid.NewGuid()},{customerCreateDto.Name},{customerCreateDto.Surname}";
            File.AppendAllText("Dosya Yolunu vereceksin",saveData);

        }

        public List<CustomerListDto> List()
        {
            List<CustomerListDto> list = new();
            string AllText = File.ReadAllText("Dosya Yolunu ver ");
            string[]lines= AllText.Split("\r\n");
            foreach (string line in lines)
            {
                var data = line.Split(",");
                CustomerListDto customerListDto = new()
                {
                    Id = Guid.Parse(data[0]),
                    Name = data[1],
                };
                list.Add(customerListDto);
            }
            return list;
        }
    }
}
