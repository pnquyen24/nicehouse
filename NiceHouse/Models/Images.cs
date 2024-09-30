using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiceHouse.Models
{
    public class Images
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImagineId { get; set; } 

        public string? Path { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; } 

        public Products? Product { get; set; }
    }
}
