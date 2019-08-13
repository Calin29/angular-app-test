using AppTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CowsController : ControllerBase
    {
        private static List<Cow> CowList = new List<Cow>
        {
            new Cow { Id = 1, Name = "Joana", Color = "Violet", Weight = 300 },
            new Cow { Id = 2, Name = "Miorita", Color = "Black", Weight = 200 },
            new Cow { Id = 3, Name = "Viorica", Color = "Yellow", Weight = 350 }
        };

        [HttpGet("[action]")]
        public IEnumerable<Cow> GetCows()
        {
            return CowList;
        }

        // GET: api/Cows/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cows
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cows/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
