namespace ORMdoga.Models.DTOs {
    public record EloadoDTO(Guid id, string EloadoNev, string EloadoNemzetiseg, string ZeneFajta, DateTime CreatedTime);

    public record CreatedEloadoDTO(string EloadoNev, string EloadtoNemzetiseg, string Zenefajta);

    public record UpdateEloadoDTO(string EloadoNev, string EloadoNemzetiseg, string ZeneFajta);


    public record SzamDTO(Guid id, string SzamCim, string SzamMegjelenes, DateTime CreatedTime, Guid EloadoId);

    public record CreatedSzamDTO(string SzamCim, string SzamMegjelenes, Guid EloadoId);

    public record UpdateSzamDTO(string SzamCim, string SzamMegjelenes);
}
