using ORMdoga.Models;
using ORMdoga.Models.DTOs;

namespace ORMdoga.Repositories {
    public interface IEloadoInterface {

        Task<IEnumerable<Eloado>> Get();

        Task<Eloado> GetById(Guid id);

        Task<Eloado> Post(CreatedEloadoDTO createDTO);

        Task<Eloado> Put(Guid id, UpdateEloadoDTO updateDTO);

        Task<Eloado> DeleteById(Guid id);

    }
}
