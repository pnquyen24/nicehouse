namespace NiceHouse.DTOs
{
    public class ImagesDTO
    {
        public int ImagineId { get; set; }  // ID của ảnh

        public string? Path { get; set; }  // Đường dẫn ảnh

        public int? ProductId { get; set; }  // ID của sản phẩm

        public string? ProductName { get; set; }  // Tên sản phẩm (tùy chọn nếu cần thêm thông tin)
    }

}
