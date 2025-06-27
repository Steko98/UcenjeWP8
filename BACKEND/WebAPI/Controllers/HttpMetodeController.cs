using System.Text;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {
        //Ruta je metoda
        //Ovdje pocinje ruta
        [HttpGet]
        public string HelloWorld()
        {
            return "hello";
        }
        //Ovdje zavrsava ruta
        //Ovdje pocinje ruta
        [HttpGet]
        [Route("pozdrav")]
        public string HelloWorld(string ime)
        {
            return new StringBuilder().Append("Hello ").Append(ime).ToString();
        }
        //Ovdje zavrsava ruta

        [HttpGet]
        [Route("json")]
        public IActionResult Json()
        {
            return Ok(new { Ime = "Pero", Prezime = "Peric" });
        }

        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            // ovdje ce ici spremanje u bazu
            return StatusCode(StatusCodes.Status201Created, osoba);
        }

        [HttpPut]
        public IActionResult Put(Osoba o)
        {
            o.Ime = "Promjenio " + o.Ime;
            return Ok(o);
        }

        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra<=0)
            {
                return BadRequest(new { poruka = "Sifra mora biti veca od 0" });
            }
            return NoContent();
        }

    }
}
