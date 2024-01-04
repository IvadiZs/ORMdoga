using ORMdoga.Models;
using ORMdoga.Models.DTOs;

namespace ORMdoga {
    public static class Extensions {

        public static EloadoDTO AsDTO(this Eloado eloado) {
            return new(eloado.id, eloado.EloadoNev, eloado.EloadoNemzetiseg, eloado.ZeneFajta, eloado.CreatedTime);
        }

        public static SzamDTO AsDTO(this Szam szam) {
            return new(szam.id, szam.SzamCim, szam.SzamMegjelenes, szam.CreatedTime, szam.EloadoId);
        }
    }
}
