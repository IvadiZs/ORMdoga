using ORMdoga.Models;
using ORMdoga.Models.DTOs;

namespace ORMdoga.Repositories {
    public class EloadoService : IEloadoInterface {

        private readonly ZeneDBContext dbContext;

        public EloadoService(ZeneDBContext dBContext) {
            this.dbContext = dbContext;
        }

        // Get

        public async Task<IEnumerable<Eloado>> Get() {
            return dbContext.Eloado.ToList();
        }

        // GetById

        // Post

        // Put

        // DeleteById

        // GetEloadoSzam
    }
}
