using Microsoft.Extensions.Hosting;
using ORMdoga.Models;
using ORMdoga.Models.DTOs;

namespace ORMdoga.Repositories {
    public class EloadoService : IEloadoInterface {

        private readonly ZeneDBContext dbContext;

        public EloadoService(ZeneDBContext dbContext) {
            this.dbContext = dbContext;
        }

        // Get

        public async Task<IEnumerable<Eloado>> Get() {
            return dbContext.Eloado.ToList();
        }

        // GetById

        public async Task<Eloado> GetById(Guid id) {

            var eloado = dbContext.Eloado.Where(x => x.id == id).FirstOrDefault();

            return eloado;
        }

        // Post

        public async Task<Eloado> Post(CreatedEloadoDTO createDTO) {

            var eloado = new Eloado {

                id = Guid.NewGuid(),
                EloadoNev = createDTO.EloadoNev,
                EloadoNemzetiseg = createDTO.EloadtoNemzetiseg,
                ZeneFajta = createDTO.Zenefajta,
                CreatedTime = DateTime.UtcNow
            };

            await dbContext.Eloado.AddAsync(eloado);
            await dbContext.SaveChangesAsync();

            return eloado;
        }

        // Put

        public async Task<Eloado> Put(Guid id, UpdateEloadoDTO updateDTO) {

            var eloado = dbContext.Eloado.Where(x => x.id == id).FirstOrDefault();

            eloado.EloadoNev = updateDTO.EloadoNev;
            eloado.EloadoNemzetiseg = updateDTO.EloadoNemzetiseg;
            eloado.ZeneFajta = updateDTO.ZeneFajta;

            await dbContext.SaveChangesAsync();
            return eloado;
        }

        // DeleteById

        public async Task<Eloado> DeleteById(Guid id) {

            var eloado = dbContext.Eloado.Where(x => x.id == id).FirstOrDefault();

            dbContext.Eloado.Remove(eloado);
            await dbContext.SaveChangesAsync();

            return eloado;
        }
    }
}
