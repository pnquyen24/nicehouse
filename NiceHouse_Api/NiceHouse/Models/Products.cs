using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiceHouse.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; } 

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public int? Rooms { get; set; }
        public float? Price { get; set; }
        public float? Square { get; set; }
        public float? Rent { get; set; }

        public ICollection<Images> Images { get; set; } = new List<Images>(); 

        public bool? IsSold { get; set; }
        public bool? IsRent { get; set; }
    }
}
