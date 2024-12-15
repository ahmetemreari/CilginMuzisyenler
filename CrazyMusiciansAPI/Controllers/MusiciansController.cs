using CrazyMusiciansAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CrazyMusiciansAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusiciansController : ControllerBase
    {
        // GET: api/musicians // Tüm müzisyen verilerini getir
        [HttpGet]
        public ActionResult<IEnumerable<Musician>> GetMusicians()
        {
            return Ok(StaticData.Musicians);
        }

        // GET: api/musicians/{id} Müzisyen verisini getir
        [HttpGet("{id}")]
        public ActionResult<Musician> GetMusicianById(int id)
        {
            var musician = StaticData.Musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound($"ID ye sahip muzisyen {id} bulunamadı.");

            return Ok(musician);
        }

        // POST: api/musicians yeni müzisyen ekle
        [HttpPost]
        public ActionResult<Musician> AddMusician([FromBody] Musician newMusician)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            newMusician.Id = StaticData.Musicians.Max(m => m.Id) + 1;
            StaticData.Musicians.Add(newMusician);
            return CreatedAtAction(nameof(GetMusicianById), new { id = newMusician.Id }, newMusician);
        }

        // PATCH: api/musicians/{id} // sadece belirli alaanı güncelle
        [HttpPatch("{id}")]
        public IActionResult UpdateFunFact(int id, [FromBody] string funFact)
        {
            var musician = StaticData.Musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound();

            if (string.IsNullOrWhiteSpace(funFact))
                return BadRequest("Eğlenceli özellik boş olamaz.");

            musician.FunFact = funFact;
            return Ok(musician);
        }

        // PUT: api/musicians/{id} tüm alaanları güncelle
        [HttpPut("{id}")]
        public IActionResult UpdateMusician(int id, [FromBody] Musician updatedMusician)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var musician = StaticData.Musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound($"ID sahip muzisyen {id} bulunmadı.");

            // Güncellenen veriyi  müzisyen ile eşleştir
            musician.Name = updatedMusician.Name;
            musician.Profession = updatedMusician.Profession;
            musician.FunFact = updatedMusician.FunFact;

            return Ok(musician);
        }

        // DELETE: api/musicians/{id} müzisyeni sil
        [HttpDelete("{id}")]
        public IActionResult DeleteMusician(int id)
        {
            var musician = StaticData.Musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound();

            StaticData.Musicians.Remove(musician);
            return NoContent();
        }
    }
}