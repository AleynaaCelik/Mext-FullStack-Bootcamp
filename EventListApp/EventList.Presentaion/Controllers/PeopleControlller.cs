using EventList.Domain.Dtos;
using EventList.Domain.Entities;
using EventListApp.Persistance.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventList.Presentaion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleControlller : ControllerBase
    {
        private readonly EventListDbContext _context;
         public PeopleControlller(EventListDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.People);
        }

        [HttpPost]
        public IActionResult Add(AddPersonDto addPersonDto)
        {
            Person person = new()
            {
                Id = Guid.NewGuid(),
                Name = addPersonDto.Name,
                PhoneNumber = addPersonDto.PhoneNumber
            };
            _context.People.Add(person);
            _context.SaveChanges();
            return Ok(person.Id);
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id,UpdatePersonDto updatePersonDto)
        {
            var selectedPerson = _context.People.FirstOrDefault(x => x.Id == id);
            
            if(selectedPerson is null)
                return NotFound("Person Not Found");

            selectedPerson.Name = updatePersonDto.Name;
            selectedPerson.PhoneNumber = updatePersonDto.PhoneNumber;
            _context.SaveChanges();
            return Ok("Changes Saved");
            
           

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id, UpdatePersonDto updatePersonDto)
        {
            var selectedPerson = _context.People.FirstOrDefault(x => x.Id == id);

            if (selectedPerson is null)
                return NotFound("Person Not Found");

            selectedPerson.Name = updatePersonDto.Name;
            selectedPerson.PhoneNumber = updatePersonDto.PhoneNumber;
            _context.SaveChanges();
            return Ok("Person deleted");



        }


    }
}
