namespace ORMdoga.Models.DTOs {
    public class DTOs {

        public record EloadoDTO(Guid id, string EloadoNev, string EloadoNemzetiseg, string ZeneFajta, DateTime CreatedTime);

        public record CreatedEloadoDTO(string EloadoNev, string EloadtoNemzetiseg, string Zenefajta);

        public record UpdateEloadoDTO(string EloadoNev, string EloadoNemzetiseg, string ZeneFajta);


        public record ZeneDTO(Guid id, string SzamCim, string SzamMegjelenes, DateTime CreatedTime);

        public record CreatedZeneDTO(string SzamCim, string SzamMegjelenes);

        public record UpdateZeneDTO(string SzamCim, string SzamMegjelenes);
    }
}
