namespace NiceHouse.Models
{

    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HotelId { get; set; } // Thêm thuộc tính HotelId
        public decimal Price { get; set; }
        public int NumberOfBeds { get; set; }
        public ICollection<RoomTypeImage> Images { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public virtual Hotel Hotel { get; set; } // Thêm navigation property cho Hotel
    }
}