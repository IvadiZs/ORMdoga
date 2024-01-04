using ORMdoga.Models;
using ORMdoga.Models.DTOs;

namespace ORMdoga.Repositories {
    public interface ISzamInterface {

        Task<IEnumerable<Szam>> Get();

        Task<Szam> GetById(Guid id);

        Task<Szam> Post(CreatedSzamDTO createDTO);

        Task<Szam> Put(Guid id, UpdateSzamDTO updateDTO);

        Task<Szam> DeleteById(Guid id);
    }
}
