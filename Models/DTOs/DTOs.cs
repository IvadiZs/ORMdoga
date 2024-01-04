namespace ORMdoga.Models.DTOs {
    public class DTOs {

        public record EloadoDTO(Guid id, string EloadoNev, string EloadoNemzetiseg, string ZeneFajta, DateTime CreatedTime);

        public record CreatedEloadoDTO(string EloadoNev, string EloadtoNemzetiseg, string Zenefajta);
    }
}
