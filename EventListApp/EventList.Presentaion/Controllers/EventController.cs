using EventList.Domain.Dtos;
using EventList.Domain.Entities;
using EventListApp.Persistance.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventList.Presentaion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventListDbContext _context;

        public EventController(EventListDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Events.In);
        }

        [HttpPost]
        public IActionResult Add(AddEventDto addEventDto)
        {
            var ownerPerson=_context.People.FirstOrDefault(x=>x.Id==addEventDto.PersonId);
            if(per)
            // AddEventDto'dan yeni bir Event nesnesi oluştur
            Event newEvent = new Event
            {
                Id = Guid.NewGuid(), // Yeni bir GUID oluştur
                Title = addEventDto.Title,
                Description = addEventDto.Description,
                Date = addEventDto.Date
            };

            // Oluşturulan etkinliği veritabanına ekle
            _context.Events.Add(newEvent);
            _context.SaveChanges();

            // Ekleme işlemi başarılı olduysa yeni etkinliğin ID'sini döndür
            return Ok(newEvent.Id);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, UpdateEventDto updateEventDto)
        {
            // Güncellenecek etkinliği veritabanından seç
            var selectedEvent = _context.Events.FirstOrDefault(x => x.Id == id);

            // Eğer etkinlik bulunamadıysa 404 NotFound döndür
            if (selectedEvent == null)
                return NotFound("Event Not Found");

            // Seçilen etkinliğin bilgilerini güncelle
            selectedEvent.Title = updateEventDto.Title;
            selectedEvent.Description = updateEventDto.Description;
            selectedEvent.Date = updateEventDto.Date;

            // Değişiklikleri veritabanına kaydet
            _context.SaveChanges();

            // İşlem başarılı olduysa 200 OK döndür
            return Ok("Changes Saved");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            // Silinecek etkinliği veritabanından seç
            var selectedEvent = _context.Events.FirstOrDefault(x => x.Id == id);

            // Eğer etkinlik bulunamadıysa 404 NotFound döndür
            if (selectedEvent == null)
                return NotFound("Event Not Found");

            // Seçilen etkinliği veritabanından kaldır
            _context.Events.Remove(selectedEvent);
            _context.SaveChanges();

            // İşlem başarılı olduysa 200 OK döndür
            return Ok("Event deleted");
        }

    }
}
