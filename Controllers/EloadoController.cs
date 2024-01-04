using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORMdoga.Models;
using ORMdoga.Models.DTOs;
using ORMdoga.Repositories;

namespace ORMdoga.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EloadoController : ControllerBase {

        private readonly IEloadoInterface eloadoInterface;

        public EloadoController(IEloadoInterface eloadoInterface) {
            this.eloadoInterface = eloadoInterface;
        }

        [HttpGet]
        public async Task<IEnumerable<Eloado>> Get() {

            return await eloadoInterface.Get();
        }
        [HttpGet("{id}")]
        public async Task<Eloado> Get(Guid id) {

            return await eloadoInterface.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Eloado>> Post(CreatedEloadoDTO createDTO) {

            return StatusCode(201, await eloadoInterface.Post(createDTO));
        }

        [HttpPut("{id}")]
        public async Task<Eloado> Put(Guid id, UpdateEloadoDTO updateDTO) {

            return await eloadoInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<Eloado> Delete(Guid id) {
            return await eloadoInterface.DeleteById(id);
        }
    }
}
