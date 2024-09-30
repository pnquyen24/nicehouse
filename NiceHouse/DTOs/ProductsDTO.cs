using NiceHouse.Models;

namespace NiceHouse.DTOs
{
    public class ProductsDTO
    {
        public int ProductId { get; set; }  // ID của sản phẩm

        public string? Name { get; set; }  // Tên sản phẩm

        public string? Description { get; set; }  // Mô tả sản phẩm

        public string? Address { get; set; }  // Địa chỉ sản phẩm

        public int? Rooms { get; set; }  // Số phòng

        public float? Price { get; set; }  // Giá

        public float? Square { get; set; }  // Diện tích

        public float? Rent { get; set; }  // Giá thuê

        public List<ImagesDTO>? Images { get; set; }  // Danh sách ảnh

        public bool? IsSold { get; set; }  // Đã bán chưa

        public bool? IsRent { get; set; }  // Đang cho thuê chưa
    }

}
