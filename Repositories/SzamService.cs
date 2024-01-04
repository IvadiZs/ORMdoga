using ORMdoga.Models;
using ORMdoga.Models.DTOs;

namespace ORMdoga.Repositories {
    public class SzamService : ISzamInterface {

        private readonly ZeneDBContext dbContext;

        public SzamService(ZeneDBContext dbContext) {
            this.dbContext = dbContext;
        }

        // Get

        public async Task<IEnumerable<Szam>> Get() {
            return dbContext.Szam.ToList();
        }

        // GetById

        public async Task<Szam> GetById(Guid id) {

            var szam = dbContext.Szam.Where(x => x.id == id).FirstOrDefault();

            return szam;
        }

        // Post

        public async Task<Szam> Post(CreatedSzamDTO createDTO) {

            var szam = new Szam {

                id = Guid.NewGuid(),
                SzamCim = createDTO.SzamCim,
                SzamMegjelenes = createDTO.SzamMegjelenes,
                CreatedTime = DateTime.UtcNow,
                EloadoId = createDTO.EloadoId
            };

            await dbContext.Szam.AddAsync(szam);
            await dbContext.SaveChangesAsync();

            return szam;
        }

        // Put

        public async Task<Szam> Put(Guid id, UpdateSzamDTO updateDTO) {

            var szam = dbContext.Szam.Where(x => x.id == id).FirstOrDefault();

            szam.SzamCim = updateDTO.SzamCim;
            szam.SzamMegjelenes = updateDTO.SzamMegjelenes;

            await dbContext.SaveChangesAsync();
            return szam;
        }

        // DeleteById

        public async Task<Szam> DeleteById(Guid id) {

            var szam = dbContext.Szam.Where(x => x.id == id).FirstOrDefault();

            dbContext.Szam.Remove(szam);
            await dbContext.SaveChangesAsync();

            return szam;
        }

        // GetEloadoSzam

        public async Task<IEnumerable<Szam>> GetEloadoSzam(Guid id) {

            var szamList = dbContext.Szam.Where(x => x.EloadoId == id).ToList();

            return szamList;
        }
    }
}
