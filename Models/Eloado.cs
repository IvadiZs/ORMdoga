using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORMdoga.Models {
    public class Eloado {

        [Key]
        public Guid id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string EloadoNev { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string EloadoNemzetiseg { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ZeneFajta { get; set; }

        public DateTime CreatedTime { get; set; } 

    }
}
