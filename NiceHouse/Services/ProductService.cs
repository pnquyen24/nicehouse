using NiceHouse.Models;
using NiceHouse.Repositories;

namespace NiceHouse.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Thêm sản phẩm
        public void AddProduct(Products product)
        {
            _productRepository.Add(product);
        }

        // Xóa sản phẩm theo ID
        public void DeleteProduct(int id)
        {
            var product = _productRepository.GetById(id);
            if (product != null)
            {
                _productRepository.Delete(id);
            }
        }

        // Lấy danh sách tất cả sản phẩm
        public IEnumerable<Products> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        // Lấy sản phẩm theo ID
        public Products GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        // Cập nhật sản phẩm
        public void UpdateProduct(Products product)
        {
            _productRepository.Update(product);
        }

        // Tìm kiếm sản phẩm theo các tiêu chí
        public IEnumerable<Products> SearchProducts(float rent, float price, int rooms, string address, bool isRent)
        {
            // Nếu địa chỉ là null hoặc rỗng, có thể gọi hàm tìm kiếm mà không cần điều kiện cho địa chỉ
            if (string.IsNullOrEmpty(address))
            {
                // Có thể gọi phương thức tìm kiếm với address là null hoặc dùng giá trị mặc định
                return _productRepository.Search(rent, price, rooms, null, isRent);
            }

            // Nếu địa chỉ không rỗng, thực hiện tìm kiếm bình thường
            return _productRepository.Search(rent, price, rooms, address, isRent);
        }

    }
}
