using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORMdoga.Models {
    public class Szam {

        [Key]
        public Guid id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string SzamCim { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string SzamMegjelenes { get; set; }

        public DateTime CreatedTime { get; set; }

        public Eloado Eloado { get; set; }

        public Guid EloadoId { get; set; }

    }
}
