using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORMdoga.Models.DTOs;
using ORMdoga.Models;
using ORMdoga.Repositories;

namespace ORMdoga.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SzamController : ControllerBase {

        private readonly ISzamInterface szamInterface;

        public SzamController(ISzamInterface szamInterface) {
            this.szamInterface = szamInterface;
        }

        [HttpGet]
        public async Task<IEnumerable<Szam>> Get() {

            return await szamInterface.Get();
        }
        [HttpGet("{id}")]
        public async Task<Szam> Get(Guid id) {

            return await szamInterface.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Szam>> Post(CreatedSzamDTO createDTO) {

            return StatusCode(201, await szamInterface.Post(createDTO));
        }

        [HttpPut("{id}")]
        public async Task<Szam> Put(Guid id, UpdateSzamDTO updateDTO) {

            return await szamInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<Szam> Delete(Guid id) {
            return await szamInterface.DeleteById(id);
        }

        [HttpGet("/byUser/{id}")]
        public async Task<IEnumerable<Szam>> GetUserPosts(Guid id) {
            return await szamInterface.GetEloadoSzam(id);
        }
    }
}
