using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORMdoga.Models;
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
    }
}
